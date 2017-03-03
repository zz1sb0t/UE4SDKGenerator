using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Project/Game Name: ");
            string name = Console.ReadLine();
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = Path.Combine(baseDir, name);
            string emptyDir = Path.Combine(baseDir, "UE4.EmptyGame");
            if (Directory.Exists(projectDir))
            {
              Console.WriteLine("This project name is already used.");
                return;
            }
            Directory.CreateDirectory(projectDir);

            foreach (var f in Directory.GetFiles(emptyDir, "*.*", SearchOption.AllDirectories))
            {
                string destFile = f.Replace(emptyDir, projectDir);
                string pDir = Path.GetDirectoryName(destFile);
                if (!Directory.Exists(pDir))
                    Directory.CreateDirectory(pDir);
                File.Copy(f, destFile,true);
                if (Path.GetFileName(destFile) == "UnrealGame.cs")
                {
                    ProcessGameFile(name,destFile);
                }
                else
                {
                    if (Path.GetFileName(destFile) == "UE4.EmptyGame.csproj")
                    {
                        ProcessProjectFile(name, destFile);
                    }
                    else ProcessFile(name, destFile);
                }
            
            }
        }
        static void ProcessProjectFile(string gameName, string file)
        {
            var fileData = File.ReadAllText(file);
            File.Delete(file);
            fileData = fileData.Replace("<RootNamespace>UE4.EmptyGame</RootNamespace>",
                $"<RootNamespace>{gameName}</RootNamespace>");
            fileData = fileData.Replace("<AssemblyName>UE4.EmptyGame</AssemblyName>",
             $"<AssemblyName>{gameName}</AssemblyName>");
            fileData = fileData.Replace("<Compile Include=\"UnrealGame.cs\" />",
                $"<Compile Include=\"{gameName}Game.cs\" />");
            File.WriteAllText(Path.Combine(Path.GetDirectoryName(file), $"{gameName}.csproj"),fileData);
        }
        static void ProcessGameFile(string gameName, string file)
        {
            var fileData = File.ReadAllText(file);
            File.Delete(file);

            fileData = fileData.Replace("UE4.EmptyGame", gameName);
            fileData = fileData.Replace("UnrealGame",gameName+"Game");
            File.WriteAllText(Path.Combine(Path.GetDirectoryName(file),gameName+"Game.cs"), fileData);
        }
        static void ProcessFile(string gameName,string file)
        {
            var fileData = File.ReadAllText(file);
            fileData = fileData.Replace("UE4.EmptyGame",gameName);
            fileData = fileData.Replace("UnrealGame.", gameName + "Game.");
            File.WriteAllText(file, fileData);
        }
    }
}
