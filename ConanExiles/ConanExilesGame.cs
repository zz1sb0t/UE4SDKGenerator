using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConanExiles.Memory;
using ConanExiles.Stores;

namespace ConanExiles
{
    public class ConanExilesGame
    {
        public IMemoryUtility Memory { get; private set; }
     

        #region Stores
        public NameStore Names { get; set; }
        public ObjectStore Objects { get; set; }
        #endregion

        #region Singleton
        private static ConanExilesGame _instance;
        public static ConanExilesGame Instance => _instance ?? (_instance = new ConanExilesGame()); 
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
