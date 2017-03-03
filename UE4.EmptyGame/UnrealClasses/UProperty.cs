namespace UE4.EmptyGame.UnrealClasses
{
    //UPropertyFinish @ 0x78
    public class UProperty:UField
    {
        public int ArrayDimension => ReadInt32(0x30);
        public int ElementSize => ReadInt32(0x34);
        public long PropertyFlags => ReadInt64(0x40);
        public int Offset => ReadInt32(0x50);
        public byte[] Unknown => ReadBytes(0x54, 0x20);
    }
}
