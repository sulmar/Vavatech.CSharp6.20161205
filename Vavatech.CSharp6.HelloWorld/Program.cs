using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.CSharp6.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Podaj imię");

            string firstname = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko");

            string lastname = Console.ReadLine();

            Console.WriteLine(firstname + " " + lastname);
            
            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }
    }
}
