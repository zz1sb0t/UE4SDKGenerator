using System;
using UE4.EmptyGame.Memory;

namespace UE4.EmptyGame.Stores
{
    public class StaticIndirectArray:MemoryObject
    {
     
        private const Int64 ElementsPerChunk = 16384;
        Int64 MaxTotalElements = 2 * 1024 * 1024;
        public IntPtr[] Chunks { get; set; }
        public Int64 ChunkTableSize => (MaxTotalElements + ElementsPerChunk - 1) / ElementsPerChunk;
        public int ElementCount=> ReadInt32(tableSizeInBytes);
        public int ChunkCount => ReadInt32(tableSizeInBytes + 4);
        public int tableSizeInBytes =>(int)ChunkTableSize * (int)IntPtr.Size;
        public StaticIndirectArray(IntPtr baseAddress)
        {
           
            Chunks = new IntPtr[ChunkTableSize];
            BaseAddress = baseAddress;
            for (int i = 0; i < ChunkTableSize; i++)
            {
                Chunks[i] = ReadIntPtr(baseAddress,(i * IntPtr.Size));
            }
        }

       
        public bool IsValidIndex(Int64 index)
        {
            return index >= 0 && index < ElementCount && GetObj(index) != IntPtr.Zero;
        }

        public IntPtr GetObj(Int64 index)
        {
            var ChunkIndex = index / ElementsPerChunk;
            var WithinChunkIndex = index % ElementsPerChunk;
         if (ChunkIndex<0)
                return IntPtr.Zero;
            IntPtr Chunk = Chunks[ChunkIndex];
            return ReadIntPtr(Chunk, ((int)WithinChunkIndex * IntPtr.Size));
        }

        public override int ObjectSize =>0;
    }
}