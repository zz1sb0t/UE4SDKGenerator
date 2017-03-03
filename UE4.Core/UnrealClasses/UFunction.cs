namespace UE4.EmptyGame.UnrealClasses
{
    public class UFunction : UStruct
    {
        public int FunctionFlags => ReadInt32(0x90);
        public byte ParamNum => ReadByte(0x96);
        public ushort ReturnValueOffset => ReadUInt16(0x9A);
    }
}