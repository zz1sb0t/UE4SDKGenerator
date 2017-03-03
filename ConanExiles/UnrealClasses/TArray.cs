using System;
using System.Collections.Generic;
using ConanExiles.Memory;

namespace ConanExiles.UnrealClasses
{
    public class TArray<T>:MemoryObject where T:MemoryObject,new()
    {
        public int Count => ReadInt32(8);
        public int Max => ReadInt32(12);
        public IntPtr ArrayData => ReadIntPtr(0);
        public T[] Values => ToArray();
        public T GetObject(int index)
        {
            if (IsPtr)
            {
                return new T() { BaseAddress = ReadIntPtr(ArrayData, (index * ElementSize)) };
            }
            else
            {
                return new T() { BaseAddress =ArrayData+ (index * ElementSize) };
            }
           
        }
        public TArray(IntPtr address)
        {
            BaseAddress = address;
            ElementSize = IntPtr.Size;
            IsPtr = true;
        }
        public TArray(IntPtr address,int elementSize,bool isPtr=true)
        {
            BaseAddress = address;
            ElementSize = elementSize;
            IsPtr = isPtr;
        }
      

        public int ElementSize { get; }
        public bool IsPtr { get; }


        public T[] ToArray()
        {
            List<T> elements = new List<T>();
            for (int i=0;i < Count;i++)
                elements.Add(GetObject(i));
            return elements.ToArray();
        }

        public override int ObjectSize => 8+IntPtr.Size;
    }
    
}