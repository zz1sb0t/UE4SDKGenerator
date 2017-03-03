using System;
using ConanExiles.Memory;

namespace ConanExiles.UnrealStructures
{
    public class FNameEntry:MemoryObject
    {
        private const int NAME_WIDE_MASK = 1;
        private const int NAME_INDEX_SHIFT = 1;
        public string Value => ReadAnsiString((IntPtr.Size * 2));

        public override string ToString()
        {
            return Value;
        }
        public override int ObjectSize => IntPtr.Size * 2;
    }
}