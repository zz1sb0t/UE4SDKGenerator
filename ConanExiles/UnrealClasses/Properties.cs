using System;

namespace ConanExiles.UnrealClasses
{
    //UPropertyFinish @ 0x78
    public class UByteProperty: UProperty
    {
    }

    public class UIntProperty : UProperty
    {
    }

    public class UFloatProperty : UProperty
    {
    }

    public class UBoolProperty : UProperty
    {
        public byte FieldSize => ReadByte(0x78);
        public byte ByteOffset => ReadByte(0x79);
        public byte ByteMask => ReadByte(0x7A);
        public byte FieldMask => ReadByte(0x7B);
        public UInt32 BitMask => ReadUInt32(0x78);
    }
    public class UArrayProperty : UProperty
    {
        public UClass Inner => SafeGet<UClass>(0x78);
    }
    public class UStructProperty : UProperty
    {
        public UStruct Struct => SafeGet<UStruct>(0x78);
    }
    public class UObjectProperty : UProperty
    {
        public UClass PropertyClass => SafeGet<UClass>(0x78);
    }

    public class UClassProperty : UProperty
    {
    }
    public class UEnumProperty : UProperty
    {
    }
    public class UNumericProperty : UProperty
    {
    }
    public class UInterfaceProperty : UProperty
    {
    }
}
