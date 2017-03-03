using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UE4.EmptyGame.Memory;
using UE4.EmptyGame.UnrealClasses;

namespace UE4.EmptyGame.SDKGenerator
{
    public class SdkGen
    {
        /// <summary>
        /// Do we want to merge each class into a file with the package name, or have each class as its own cs file
        /// </summary>
        public bool MergePackageClasses => true;
        public Dictionary<string,List<SDKClass>> Classes { get; set; }=new Dictionary<string, List<SDKClass>>();
        string[] GenerateIgnoreList()
        {
            List<string> types = new List<string>();
            foreach (var t in Assembly.GetExecutingAssembly().GetTypes())
            {
                types.Add(t.Name);
            }
            return types.ToArray();
        }
       
        
        public void Generate()
        {
            UnrealGame.Instance.Initialize(true);
            var ignore = GenerateIgnoreList();
            for (int i = 0; i < UnrealGame.Instance.Objects.Count; i++)
            {
                var obj = UnrealGame.Instance.Objects.Get(i);
                if (obj.IsA<UClass>())
                {
                    if (!ignore.Contains(obj.NameWithPrefix))
                    {
                        Console.WriteLine($"Generating Class {obj.NameWithPrefix}");
                        var sdkClass = ProcessClass(obj.Cast<UClass>());
                        if (!Classes.ContainsKey(sdkClass.Namespace))
                            Classes.Add(sdkClass.Namespace,new List<SDKClass>());
                        Classes[sdkClass.Namespace].Add(sdkClass);
                       
                    }
                }
                if (obj.IsA<UScriptStruct>())
                {
                    if (!ignore.Contains(obj.NameWithPrefix))
                    {
                        Console.WriteLine($"Generating Struct {obj.NameWithPrefix}");
                        var sdkClass = ProcessStruct(obj.Cast<UScriptStruct>());
                        if (!Classes.ContainsKey(sdkClass.Namespace))
                            Classes.Add(sdkClass.Namespace, new List<SDKClass>());
                        Classes[sdkClass.Namespace].Add(sdkClass);
                    }
                }
            }
            WriteClassFiles();
        }

        void WriteClassFiles()
        {
            string destDir = "C:\\SDK";
            if (MergePackageClasses)
            {
                foreach (var c in Classes)
                {
                    if (c.Value.Count==0)
                        continue;
                    List<string>namespaces = new List<string>();
                    foreach (var obj in c.Value)
                    {
                        foreach (var nss in obj.UsedNamespaces)
                        {
                            if (!namespaces.Contains(nss))
                                namespaces.Add(nss);
                        }
                    }
                    string filename = c.Key + ".cs";
                    var ns = c.Key;
                    ExtendedStringBuilder sb = new ExtendedStringBuilder();
                    sb.SetNamespaceIndent();
                    foreach (var s in namespaces)
                    {
                        sb.AppendLine($"using {s};");
                    }
                    sb.AppendLine("");
                    sb.AppendLine("");
                    sb.AppendLine($"namespace {ns}");
                    sb.AppendLine("{");
                    sb.SetNamespaceIndent();
                    foreach (var obj in c.Value)
                    {
                       obj.BuildClass(sb);
                    }
                    sb.SetNamespaceIndent();
                    sb.AppendLine("}");
                   File.WriteAllText(Path.Combine(destDir,filename),sb.ToString());
                }
            }
        }
        SDKClass ProcessStruct(UScriptStruct @class)
        {
            var sdkc = new SDKClass();
            sdkc.ClassName = SDKUtilities.CleanupName(@class.NameWithPrefix);
            if (@class.SuperField != null)
            {
                sdkc.SuperClass = SDKUtilities.CleanupName(@class.SuperField.NameWithPrefix);
                var scNamespace = SDKUtilities.GetPackageName(@class.SuperField.Cast<UClass>());
                if (!sdkc.UsedNamespaces.Contains(scNamespace))
                    sdkc.UsedNamespaces.Add(scNamespace);
            }
            sdkc.ClassSize = @class.PropertySize;
            sdkc.Namespace = SDKUtilities.GetPackageName(@class.Cast<UClass>());
            var child = @class.Children;
            while (child != null)
            {
                if (child.IsA<UProperty>())
                {
                    sdkc.AddProperty(child.Cast<UProperty>());
                }
                child = child.Next;
            }
            return sdkc;
        }
        SDKClass ProcessClass(UClass @class)
        {
            var sdkc = new SDKClass();
            sdkc.ClassName = SDKUtilities.CleanupName(@class.NameWithPrefix);
            if (@class.SuperField != null)
            {
                sdkc.SuperClass= SDKUtilities.CleanupName(@class.SuperField.NameWithPrefix);
                var scNamespace = SDKUtilities.GetPackageName(@class.SuperField.Cast<UClass>());
                if (!sdkc.UsedNamespaces.Contains(scNamespace))
                    sdkc.UsedNamespaces.Add(scNamespace);
            }
            sdkc.ClassSize = @class.PropertySize;
            sdkc.Namespace = SDKUtilities.GetPackageName(@class);
            var child = @class.Children;
            while (child != null)
            {
                if (child.IsA<UProperty>())
                {
                    sdkc.AddProperty(child.Cast<UProperty>());
                }
                child = child.Next;
            }
            return sdkc;
        }
    }
}
