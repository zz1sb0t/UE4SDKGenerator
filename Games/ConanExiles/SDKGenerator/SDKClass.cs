using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConanExiles.UnrealClasses;

namespace ConanExiles.SDKGenerator
{
    public class SDKClass
    {
        public string ClassName { get; set; }
        public string SuperClass { get; set; }
        public string Namespace { get; set; }
        public int ClassSize { get; set; }
        public List<string> UsedNamespaces { get; set; }=new List<string>();
        public Dictionary<string, SDKProperty> Properties { get; set; } = new Dictionary<string, SDKProperty>();
        public void AddProperty(UProperty property, string classname = null, string name = null)
        {
            string propname = name;
            if (propname == null)
                propname = SDKUtilities.CleanupName(property.Name);
            if (classname == null)
                classname = property.Class.Name;
            if (Properties.ContainsKey(propname))
            {
                int counter = 1;
                while (Properties.ContainsKey(propname + counter))
                    counter++;
                propname += counter;
            }
            bool supported = true;
            string subtype = "";
            string arraySubType = "";
            int subElementSize = 0;
            switch (classname)
            {
                case "AssetObjectProperty":
                case "WeakObjectProperty":
                case "MulticastDelegateProperty":
                {
                    supported = false;
                    break;
                }
                case "ArrayProperty":
                {
                    var arrayProp = property.Cast<UArrayProperty>();
                    subtype = property.Cast<UArrayProperty>().Inner.Class.Name;
                    switch (subtype)
                    {
                        case "NameProperty":
                        {
                            arraySubType = "FName";
                            break;
                        }
                            case "ObjectProperty":
                                {
                                    subElementSize = arrayProp.Inner.Cast<UObjectProperty>().PropertyClass.PropertySize;
                                    arraySubType = arrayProp.Inner.Cast<UObjectProperty>().PropertyClass.NameWithPrefix;
                                    var nsProp = SDKUtilities.GetPackageName(arrayProp.Inner.Cast<UObjectProperty>().PropertyClass);
                                    if (!UsedNamespaces.Contains(nsProp))
                                        UsedNamespaces.Add(nsProp);
                                    break;
                                }
                            case "StructProperty":
                                {
                                    arraySubType = arrayProp.Inner.Cast<UStructProperty>().Struct.NameWithPrefix;
                                    subElementSize = arrayProp.Inner.Cast<UStructProperty>().Struct.PropertySize;
                                    var nsProp = SDKUtilities.GetPackageName(arrayProp.Inner.Cast<UStructProperty>().Struct.Cast<UClass>());
                                    if (!UsedNamespaces.Contains(nsProp))
                                        UsedNamespaces.Add(nsProp);
                                    break;
                                }
                        }
                    break;
                }
                case "ObjectProperty":
                {
                    subtype = property.Cast<UObjectProperty>().PropertyClass.NameWithPrefix;
                    subElementSize =property.Cast<UObjectProperty>().PropertyClass.PropertySize;
                        var nsProp = SDKUtilities.GetPackageName(property.Cast<UObjectProperty>().PropertyClass);
                        if (!UsedNamespaces.Contains(nsProp))
                            UsedNamespaces.Add(nsProp);
                        break;
                }
                case "StructProperty":
                {
                    subtype = property.Cast<UStructProperty>().Struct.NameWithPrefix;
                   subElementSize = property.Cast<UStructProperty>().Struct.PropertySize;
                    var nsProp = SDKUtilities.GetPackageName(property.Cast<UStructProperty>().Struct.Cast<UClass>());
                        if (!UsedNamespaces.Contains(nsProp))
                            UsedNamespaces.Add(nsProp);
                    break;
                }
            }
            if (supported)
            {
                var prop = new SDKProperty()
                {
                    Name = propname,
                    ElementSize = property.ElementSize,
                    IsTArray = classname == "ArrayProperty",
                    Offset = property.Offset,
                    Type = classname,
                    SubType = subtype,
                    SubElementSize = subElementSize,
                    ArraySubType =arraySubType
                };
                Properties.Add(propname, prop);
            }
        }
        void WriteSummary(ExtendedStringBuilder sb)
        {
            sb.SetClassIndent();
            sb.AppendLine("/// <summary>");
            sb.AppendLine($"/// {ClassName}:{SuperClass}");
            sb.AppendLine($"/// Size: 0x{ClassSize:X2}");
            sb.AppendLine($"/// Properties: {Properties.Count}");
            sb.AppendLine( "/// </summary>");
        }

        public SDKClass()
        {
            UsedNamespaces.Add("ConanExiles");
            UsedNamespaces.Add("ConanExiles.Memory");
            UsedNamespaces.Add("ConanExiles.UnrealClasses");
            UsedNamespaces.Add("ConanExiles.UnrealStructures");
        }
        public void BuildClass(ExtendedStringBuilder sb)
        {
            sb.SetClassIndent();
            WriteSummary(sb);
            if (string.IsNullOrEmpty(SuperClass))
                SuperClass = "MemoryObject";
            sb.AppendLine($"public class {ClassName}:{SuperClass}");
            sb.AppendLine("{");
            sb.SetPropertyIndent();
            sb.AppendLine($"public override int ObjectSize => {ClassSize};");
            foreach (var p in Properties.Values.ToArray())
            {
                p.BuildProperty(sb);
                sb.AppendLine("");
            }
            sb.SetClassIndent();
            sb.AppendLine("}");
            sb.SetNamespaceIndent();
            sb.AppendLine("");
            sb.AppendLine("");
        }

    }
}
