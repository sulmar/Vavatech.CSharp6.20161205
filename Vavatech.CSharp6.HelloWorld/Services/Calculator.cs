using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.CSharp6.HelloWorld.Services
{
    class Calculator
    {

        public int Add(int x, int y)
        {
            int result = x + y;

            return result;
        }


        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}
