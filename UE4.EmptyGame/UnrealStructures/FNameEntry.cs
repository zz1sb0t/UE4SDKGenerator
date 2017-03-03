using System;
using UE4.EmptyGame.Memory;

namespace UE4.EmptyGame.UnrealStructures
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