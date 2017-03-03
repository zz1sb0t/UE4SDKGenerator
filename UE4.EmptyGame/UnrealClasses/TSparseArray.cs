using System;
using System.Collections;
using System.Collections.Generic;
using UE4.EmptyGame.Memory;

namespace UE4.EmptyGame.UnrealClasses
{
    public class TSparseArray<T> : MemoryObject where T : MemoryObject, new()
    {
        public int ElementSize { get; }
        public IntPtr ArrayData => ReadIntPtr(BaseAddress, 0);
        public int Count => ReadInt32(8);
        public int Max => ReadInt32(12);
        public int FirstFreeIndex => ReadInt32(0x30);
        public int NumFreeIndices => ReadInt32(0x34);
  

        public TSparseArray(IntPtr baseAddress, int elementSize)
        {
            ElementSize = elementSize;
            BaseAddress = baseAddress;
        }

        public T[] GetAllElements()
        {
            List<T> elements = new List<T>();
            int counter = 0;
            int c = Count - NumFreeIndices;
            var BitArray = new BitArray(ReadBytes(0x10, 24));
            for (int i = 0; i < c; i++)
            {
                if (BitArray[i])
                {
                    elements.Add(GetObject(i));
                }
                counter++;
            }
            return elements.ToArray();
        }

       
        public T GetObject(int index)
        {
            return new T() {BaseAddress = ArrayData + (ElementSize * index)};
        }

        public override int ObjectSize => 44 + IntPtr.Size;
    }
}