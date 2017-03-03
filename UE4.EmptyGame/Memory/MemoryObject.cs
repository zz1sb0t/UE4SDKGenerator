using System;
using SharpDX;

namespace UE4.EmptyGame.Memory
{
    public abstract class MemoryObject
    {
        public abstract int ObjectSize { get; }
        public IntPtr BaseAddress { get; set; }

        public IMemoryUtility Memory => UnrealGame.Instance.Memory;

        public T SafeGet<T>(int offset) where T : MemoryObject, new()
        {
            return Memory.SafeGet<T>(BaseAddress, offset);
        }
        public bool ReadBool(int offset)
        {
            return Memory.ReadBool(BaseAddress, offset);
        }
        public byte ReadByte(int offset)
        {
            return Memory.ReadByte(BaseAddress, offset);
        }

        public float ReadFloat(int offset)
        {
            return ReadSingle(offset);
        }
        public double ReadDouble(int offset)
        {
            return Memory.ReadDouble(BaseAddress, offset);
        }
        public short ReadInt16(int offset)
        {
            return Memory.ReadInt16(BaseAddress, offset);
        }
        public ushort ReadUInt16(int offset)
        {
            return Memory.ReadUInt16(BaseAddress, offset);
        }
        public int ReadInt32(int offset)
        {
            return Memory.ReadInt32(BaseAddress, offset);
        }
        public uint ReadUInt32(int offset)
        {
            return Memory.ReadUInt32(BaseAddress, offset);
        }
        public ulong ReadUInt64(int offset)
        {
            return Memory.ReadUInt64(BaseAddress, offset);
        }
        public long ReadInt64(int offset)
        {
            return Memory.ReadInt64(BaseAddress, offset);
        }

        public float ReadSingle(int offset)
        {
            return Memory.ReadSingle(BaseAddress, offset);
        }

        public Vector4 ReadVector4(int offset)
        {
            return Memory.ReadVector4(BaseAddress, offset);
        }

        public Vector3 ReadVector3(int offset)
        {
            return Memory.ReadVector3(BaseAddress, offset);
        }

        public Vector2 ReadVector2(int offset)
        {
            return Memory.ReadVector2(BaseAddress, offset);
        }

        public Matrix ReadMatrix(int offset)
        {
            return Memory.ReadMatrix(BaseAddress, offset);
        }

        public string ReadAnsiString(int offset)
        {
            return Memory.ReadAnsiString(BaseAddress, offset);
        }
        public IntPtr ReadIntPtr(IntPtr address, int offset)
        {
            return Memory.ReadIntPtr(address, offset);
        }
        public IntPtr ReadIntPtr(int offset)
        {
            return Memory.ReadIntPtr(BaseAddress, offset);
        }


        public T ReadUObject<T>(int offset) where T : MemoryObject, new()
        {
            return Memory.ReadUObject<T>(BaseAddress, offset);
        }


        public T ReadStruct<T>(int offset) where T : MemoryObject, new()
        {
            return Memory.ReadStruct<T>(BaseAddress, offset);
        }

        public byte[] ReadBytes(int offset, int length)
        {
            return Memory.ReadBytes(BaseAddress, offset, length);
        }

        public void WriteBool(int offset, bool value)
        {
            Memory.WriteBool(BaseAddress, offset, value);
        }

        public void WriteInt64(int offset, long value)
        {
           Memory.WriteInt64(BaseAddress, offset, value);
        }

        public void WriteInt32(int offset, int value)
        {
            Memory.WriteInt32(BaseAddress, offset, value);
        }

        public void WriteInt16(int offset, short value)
        {
            Memory.WriteInt16(BaseAddress, offset, value);
        }

        public void WriteUInt64(int offset, ulong value)
        {
            Memory.WriteUInt64(BaseAddress, offset, value);
        }

        public void WriteUInt32(int offset, uint value)
        {
           Memory.WriteUInt32(BaseAddress, offset, value);
        }

        public void WriteUInt16(int offset, ushort value)
        {
            Memory.WriteUInt16(BaseAddress, offset, value);
        }

        public void WriteByte(int offset, byte value)
        {
            Memory.WriteByte(BaseAddress, offset, value);
        }
        public void WriteDouble(int offset, double value)
        {
            Memory.WriteDouble(BaseAddress, offset, value);
        }
        public void WriteSingle(int offset, float value)
        {
            Memory.WriteSingle(BaseAddress, offset, value);
        }

    }
}
