using System;
using UE4.Core.UnrealStructures;

namespace UE4.Core.Stores
{
    public class NameStore
    {

        public StaticIndirectArray Table { get; set; }
        public int Count => (int)Table.ElementCount;
        public NameStore(IntPtr baseAddress)
        {
            Table=new StaticIndirectArray(baseAddress);
        }
        public FNameEntry Get(int index)
        {
            IntPtr data = Table.GetObj(index);
            if (data == IntPtr.Zero)
                return null;
            return new FNameEntry() {BaseAddress =data };
        }

        public IntPtr GetPtr(int index)
        {
            return Table.GetObj(index);
        }
    }
}
