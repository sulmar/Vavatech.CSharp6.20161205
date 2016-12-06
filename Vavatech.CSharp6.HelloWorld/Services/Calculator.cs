using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.CSharp6.HelloWorld.Services
{
    class Calculator : object
    {

        public int Add(int x, int y, int z = 0, string description = "")
        {
            if (x < 0 || x > 100)
                throw new ArgumentOutOfRangeException(nameof(x));

            if (y < 0 || y > 100)
                throw new ArgumentOutOfRangeException(nameof(y));

            if (z < 0 || z > 100)
                throw new ArgumentOutOfRangeException(nameof(z));


            return x + y + z;
        }

        public bool TryAdd(int x, int y, out int result)
        {
            x = 10;

            result = x + y;

            return result <= 100;

        }
    }
}
