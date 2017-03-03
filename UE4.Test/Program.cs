using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConanExiles.SDKGenerator;

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
