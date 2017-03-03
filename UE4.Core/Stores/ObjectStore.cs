using System;
using UE4.Core.Memory;
using UE4.Core.UnrealClasses;

namespace UE4.Core.Stores
{


    public class ObjectStore :MemoryObject
    {
      
        public int MaxElements { get; set; }
        public int Count => ReadInt32(28);
        public ObjectStore(IntPtr baseAddress)
        {
            BaseAddress = baseAddress;
            MaxElements = ReadInt32(24);
        }

       
        public int ObjFirstGCIndex { get; set; }
        public int ObjLastNonGCIndex { get; set; }
        public long OpenForDisregardForGC { get; set; }
        public UObject Get(int index)
        {
            return GetPtr(index);
        }

        public UObject Find(string fullname)
        {
            for (int i = 0; i < Count; i++)
            {
                var obj = Get(i);
                if (obj != null)
                {
                    string name = obj.GetFullName();
                    if (name == fullname)
                        return obj;
                }
            }
            return null;
        }
        public IntPtr GetPtr(int index)
        {
            IntPtr data = ReadIntPtr(16);
            IntPtr address = ReadIntPtr(new IntPtr(data.ToInt64()) , (index * 16));
            return address;
        }

        public override int ObjectSize => 0;
    }
}