using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.CSharp6.HelloWorld.Models;

namespace Vavatech.CSharp6.HelloWorld
{
    class Printer<TItem>
    {
        public void Print(TItem x)
        {
            Console.WriteLine($"Printing... {x}");
        }

    }
}
