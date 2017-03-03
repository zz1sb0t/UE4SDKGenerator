using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UE4.EmptyGame;
using UE4.EmptyGame.Memory;

namespace UE4.SDKGenerator
{
    public class SDKGen
    {
        public IMemoryUtility MemoryType { get; }
        public IntPtr GObjects { get; }
        public IntPtr GNames { get; }

        public SDKGen(IMemoryUtility memoryType,IntPtr gObjects,IntPtr gNames)
        {
            MemoryType = memoryType;
            GObjects = gObjects;
            GNames = gNames;
        }

        public void Generate()
        {
            UnrealGame.Instance.Initialize(MemoryType,GObjects,GNames);
        }
    }
}
