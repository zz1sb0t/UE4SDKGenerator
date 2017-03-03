using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UE4.Core.Memory;
using UE4.Core.Stores;

namespace UE4.Core
{
    public class UnrealGame
    {
        public IMemoryUtility Memory { get; private set; }
     

        #region Stores
        public NameStore Names { get; set; }
        public ObjectStore Objects { get; set; }
        #endregion

        #region Singleton
        private static UnrealGame _instance;
        public static UnrealGame Instance => _instance ?? (_instance = new UnrealGame()); 
        #endregion


        public void Initialize(IMemoryUtility memoryType,IntPtr gObjects,IntPtr gNames)
        {
            Memory = memoryType;
            Memory.Initialize();
            Names = new NameStore(Memory.ReadIntPtr(gNames,0));
            Objects=new ObjectStore(Memory.ReadIntPtr(gObjects,0));
        }
    }
}
