using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.CSharp6.HelloWorld.Services
{
    class Calculator
    {

        public int Add(int x, int y, int z = 0, string description = "")
        {
            return x + y + z;
        }

        public bool TryAdd(int x, int y, out int result)
        {
            result = x + y;

            return result <= 100;

        }
    }
}
