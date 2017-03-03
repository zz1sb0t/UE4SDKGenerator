using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UE4.EmptyGame.Memory;
using UE4.EmptyGame.Stores;

namespace UE4.EmptyGame
{
    public class UnrealGame
    {
        public string Name => "UnrealGame";

        public IMemoryUtility Memory { get; private set; }
        /// <summary>
        /// The pointer to the Names Array
        /// </summary>
        public IntPtr GNamesPtr { get; set; }
        /// <summary>
        /// The pointer to the Objects Array
        /// </summary>
        public IntPtr GObjectsPtr { get; set; }

        public byte[] GNamesPatternBytes =
        {
            0x48, 0x89, 0x1D, 0x00, 0x00, 0x00, 0x00, 0x48, 0x8B, 0x5C, 0x24, 0x00, 0x48,
            0x83, 0xC4, 0x28
        };

        public string GNamesPattern = "xxx????xxxx?xxxx";

        public byte[] GObjectsPatternBytes =
        {
            0x48, 0x8D, 0x0D, 0x00, 0x00, 0x00, 0x00, 0xE8, 0x00, 0x00, 0x00, 0x00, 0x48, 0x8D, 0x4C, 0x24, 0x00, 0x48,
            0x89, 0x74, 0x24, 0x00
        };

        public string GObjectsPattern = "xxx????x????xxxx?xxxx?";

        #region Stores

        public NameStore Names { get; set; }
        public ObjectStore Objects { get; set; }

        #endregion

        #region Singleton

        private static UnrealGame _instance;
        public static UnrealGame Instance => _instance ?? (_instance = new UnrealGame());

        #endregion

        public void Initialize(bool usePatternScan=false)
        {
            Memory = new RemoteMemory(Process.GetCurrentProcess());
            Memory.Initialize();
            #region PatternScanner
            if (usePatternScan)
            {
                var scan = new SigScan(Memory.Process, Memory.ProcessBaseAddress, Memory.Process.MainModule.ModuleMemorySize);
                var gnamesPtr = scan.FindPattern(GNamesPatternBytes, GNamesPattern, 0);
                int offset = Memory.ReadInt32(gnamesPtr, 3);
                GNamesPtr = Memory.ReadIntPtr(new IntPtr(gnamesPtr.ToInt64() + offset + 7), 0);
                var gObjectsPtr = scan.FindPattern(GObjectsPatternBytes, GObjectsPattern, 0);
                offset = Memory.ReadInt32(gObjectsPtr, 3);
                GObjectsPtr = new IntPtr(gObjectsPtr.ToInt64() + offset + 7);
            } 
            #endregion
            Names = new NameStore(GNamesPtr);
            Objects = new ObjectStore(GObjectsPtr);
        }
    }
}