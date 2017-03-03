using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UE4.EmptyGame.SDKGenerator;

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
