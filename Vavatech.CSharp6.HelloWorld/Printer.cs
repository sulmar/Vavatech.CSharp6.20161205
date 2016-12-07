using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.CSharp6.HelloWorld.Models;

namespace Vavatech.CSharp6.HelloWorld
{
    class Printer : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }

        public void Print<TItem>(TItem x)
        {
            Console.WriteLine($"Printing... {x}");
        }

    }
}
