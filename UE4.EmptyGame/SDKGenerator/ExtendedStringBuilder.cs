using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE4.EmptyGame.SDKGenerator
{
    
    public class ExtendedStringBuilder
    {
        public StringBuilder Sb { get; set; }

        public int Indent { get; private set; } = 0;
        public void SetNamespaceIndent() => Indent = 0;
        public void SetClassIndent() => Indent =1;
        public void SetPropertyIndent() => Indent = 2;
        public void SetGetSetIndet() => Indent = 3;
        public void SetInsideGetSet() => Indent = 4;
        public ExtendedStringBuilder()
        {
            Sb=new StringBuilder();
        }

        string GetIndentString()
        {
            string res = "";
            for (int i = 0; i < Indent; i++)
            {
                res += '\t';
            }
            return res;
        }

        public override string ToString()
        {
            return Sb.ToString();
        }

        public void AppendLine(string line)
        {
            Sb.AppendLine($"{GetIndentString()}{line}");
        }
        public void IncreaseIndent()
        {
            Indent++;
        }

        public void DecreaseIndent()
        {
            Indent = Math.Max(0, Indent - 1);
        }
    }
}
