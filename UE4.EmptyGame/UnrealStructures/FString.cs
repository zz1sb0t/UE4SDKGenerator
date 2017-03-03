using System;
using System.Text;
using UE4.EmptyGame.Memory;

namespace UE4.EmptyGame.UnrealStructures
{

    public class FString : MemoryObject
    {
        public FString(IntPtr intPtr)
        {
            BaseAddress = intPtr;
        }
        public int Count => ReadInt32(8);
        public int Max => ReadInt32(12);
        public IntPtr ArrayData => ReadIntPtr(0);
        public string ReadUnicodeString()
        {
            byte[] buffer = UnrealGame.Instance.Memory.ReadBytes(ArrayData,0, Count*2);
            return Encoding.Unicode.GetString(buffer).TrimEnd('\0');
        }

        public string Value => ReadUnicodeString();
        public override string ToString()
        {
            return Value;
        }

        public override int ObjectSize => 12+IntPtr.Size;
    }
}