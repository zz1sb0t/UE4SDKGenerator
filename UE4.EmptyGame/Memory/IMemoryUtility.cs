using System;
using System.Diagnostics;
using SharpDX;

namespace UE4.EmptyGame.Memory
{
    public interface IMemoryUtility
    {
        IntPtr ProcessBaseAddress { get; set; }
        Process Process { get; set; }
        void Initialize();
        string ReadAnsiString(IntPtr address, int offset);
        bool ReadBool(IntPtr address, int offset);
        byte ReadByte(IntPtr address, int offset);
        byte[] ReadBytes(IntPtr address,int offset, int length);
        double ReadDouble(IntPtr address, int offset);
        int ReadInt32(IntPtr address, int offset);
        long ReadInt64(IntPtr address, int offset);
        IntPtr ReadIntPtr(IntPtr address, int offset);
        Matrix ReadMatrix(IntPtr address, int offset);
        float ReadSingle(IntPtr address, int offset);
        T ReadStruct<T>(IntPtr address, int offset) where T : MemoryObject, new();
        short ReadInt16(IntPtr address, int offset);
        ushort ReadUInt16(IntPtr address, int offset);
        uint ReadUInt32(IntPtr address, int offset);
        ulong ReadUInt64(IntPtr address, int offset);
        T ReadUObject<T>(IntPtr address, int offset) where T : MemoryObject, new();
        Vector2 ReadVector2(IntPtr address, int offset);
        Vector3 ReadVector3(IntPtr address, int offset);
        Vector4 ReadVector4(IntPtr address, int offset);
        T SafeGet<T>(IntPtr address, int offset) where T : MemoryObject, new();
        void WriteBool(IntPtr address, int offset, bool value);
        void WriteInt64(IntPtr address, int offset, Int64 value);
        void WriteInt32(IntPtr address, int offset, int value);
        void WriteInt16(IntPtr address, int offset, short value);
        void WriteUInt64(IntPtr address, int offset, UInt64 value);
        void WriteUInt32(IntPtr address, int offset, uint value);
        void WriteUInt16(IntPtr address, int offset, ushort value);
        void WriteByte(IntPtr address, int offset, byte value);
        void WriteSingle(IntPtr address, int offset, float value);
        void WriteDouble(IntPtr address, int offset, double value);
        
    }
}