using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConanExiles.UnrealClasses;

namespace ConanExiles.SDKGenerator
{
    public static class SDKUtilities
    {
        public static string GetPackageName(UClass @class)
        {
            var package = @class.GetPackageName();
            var data = package.Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries);
            string[] data2=new string[0];
            if (data.Length > 1)
            {
                data2=new string[data.Length-1];
                for (int i = 0; i < data2.Length; i++)
                    data2[i] = CleanupName(data[i]);
            }
            if (data.Length == 0)
            {
                package = ConanExilesGame.Instance.Name;
            }
            else
            {
                package = ConanExilesGame.Instance.Name + "." + string.Join(".", data2);
            }
            return package;
        }

        public static string CleanupName(string name)
        {
            name = name.Replace(")", "").Replace("%", "").Replace("(", "").Replace(":", "").Replace("-", "").Replace("/", "").Replace("?", "").Replace("+", "").Replace(",", "").Replace("!", "");
            switch (name[0])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    name = "_" + name; break;
            }
            name = name.Replace("checked", "Checked");
            return name;
        }
    }
}
