using System;
using UE4.EmptyGame.UnrealStructures;

namespace UE4.EmptyGame.Stores
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
