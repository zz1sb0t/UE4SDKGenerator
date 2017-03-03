namespace ConanExiles.UnrealClasses
{
    public class UStruct : UField
    {
        public UStruct SuperField => SafeGet<UStruct>(0x30);
        public UField Children => SafeGet<UField>(0x38);
        public int PropertySize => ReadInt32(0x40);
        public int MinAlignmnet => ReadInt32(0x44);
    }
}