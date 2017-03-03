using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConanExiles.SDKGenerator
{
    public class SDKProperty
    {
        public bool IsTArray { get; set; } = false;
        public string Type { get; set; }
        public int Offset { get; set; }
        public int ElementSize { get; set; }
        public string Name { get; set; }
        public string SubType { get; set; }
        public int SubElementSize { get; set; }
        public string ArraySubType { get; set; }

        public uint BoolFieldMask { get; set; }
        public uint BoolOffset { get; set; }
        public uint BoolByteMask { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sb"></param>
        void WritePropertSummary(ExtendedStringBuilder sb)
        {
            sb.AppendLine("/// <summary>");
            sb.AppendLine($"/// Name: {Name}");
            sb.AppendLine(IsTArray ? $"/// Type: TArray<{ArraySubType}>" : $"/// Type: {Type}");
            sb.AppendLine($"/// Offset: 0x{Offset:X2}");
            sb.AppendLine($"/// Size: 0x{ElementSize:X2}");
            if (IsTArray)
            {
                sb.AppendLine($"/// SubElement Size: 0x{SubElementSize:X2}");
            }
            sb.AppendLine("/// </summary>");
        }

        public string Test
        {
            get
            {
                return "";
            }
            set
            {
                
            }
        }

        public uint BitMask { get; set; }

        void GetSetProperty(ExtendedStringBuilder sb,int offset,string type,string readType,string name)
        {
            sb.SetPropertyIndent();
            sb.AppendLine($"public {type} {Name}");
            sb.AppendLine("{");
            sb.SetGetSetIndet();
            sb.AppendLine("get");
            sb.AppendLine("{");
            sb.SetInsideGetSet();
            sb.AppendLine($"return Read{readType}(0x{offset:X2});");
            sb.SetGetSetIndet();
            sb.AppendLine("}");
            sb.AppendLine("set");
            sb.AppendLine("{");
            sb.SetInsideGetSet();
            sb.AppendLine($"Write{readType}(0x{offset:X2},value);");
            sb.SetGetSetIndet();
            sb.AppendLine("}");
            sb.SetPropertyIndent();
            sb.AppendLine("}");

        }
        public void BuildProperty(ExtendedStringBuilder sb)
        {
            sb.SetPropertyIndent();
            WritePropertSummary(sb);
            switch (Type)
            {
                case "BoolProperty":
                {
                    if (BoolFieldMask == 0xFF)
                    {
                        GetSetProperty(sb,(int)(Offset+BoolOffset),"bool","Bool",Name);
                    }
                    else
                    {
                        sb.AppendLine($"public bool {Name} => (ReadByte(0x{Offset + BoolOffset:X4}) & 0x{BoolByteMask:X2}) == 0x{BoolByteMask:X2};");
                    }
                    break;
                }
                case "StrProperty":
                    {
                        sb.AppendLine($"public FString {Name} => new FString(BaseAddress+0x{Offset:X2});");
                        break;
                }
                case "StructProperty":
                    {
                        sb.AppendLine($"public {SubType} {Name} => ReadStruct<{SubType}>(0x{Offset:X2});");
                        break;
                    }
                case "ObjectProperty":
                {
                        sb.AppendLine($"public {SubType} {Name} => ReadUObject<{SubType}>(0x{Offset:X2});");
                        break;
                }
               
                case "ArrayProperty":
                {
                        if (!string.IsNullOrEmpty(ArraySubType))
                        sb.AppendLine($"public TArray<{ArraySubType}> {Name} => new TArray<{ArraySubType}>(BaseAddress+0x{Offset:X2});");
                        break;
                }
                case "DoubleProperty":
                {
                    GetSetProperty(sb, Offset, "double","Double", Name);
                        break;
                    }
                  
                case "FloatProperty":
                    {
                        GetSetProperty(sb, Offset, "float", "Single", Name);
                        break;
                    }
                case "IntProperty":
                {
                        GetSetProperty(sb, Offset, "int", "Int32", Name);
                        break;
                }
                case "UIntProperty":
                    {
                        GetSetProperty(sb, Offset, "uint", "UInt32", Name);
                        break;
                    }
                case "Int16Property":
                    {
                        GetSetProperty(sb, Offset, "short", "Int16", Name);
                        break;
                    }
                case "UInt16Property":
                    {
                        GetSetProperty(sb, Offset, "ushort", "UInt16", Name);
                        break;
                    }
                case "UInt64Property":
                    {
                        GetSetProperty(sb, Offset, "ulong", "UInt64", Name);
                        break;
                    }
                case "Int64Property":
                    {
                        GetSetProperty(sb, Offset, "long", "Int64", Name);
                        break;
                    }
                case "ByteProperty":
                    {
                        GetSetProperty(sb, Offset, "byte", "Byte", Name);
                        break;
                    }
            }
        }
    }
}
