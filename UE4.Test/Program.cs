using ConanExiles.SDKGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace UE4.Test
{
    class Program
    {
        static void Main(string[] args)
        {
          SdkGen gen = new SdkGen();
            gen.Generate();
        }
    }
}
