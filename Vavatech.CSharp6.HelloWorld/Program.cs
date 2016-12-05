using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.CSharp6.Logic;
using Vavatech.CSharp6.HelloWorld.Services;

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

            double weight = 10.123;

            // C# 6.0 Interpolacja
            string fullname = $"{firstname} {lastname} {weight:N2} {DateTime.Now:yyyy-MM-dd HH.mm}";

            Console.WriteLine(fullname);

            Vavatech.CSharp6.HelloWorld.Services.Calculator calculator = new Vavatech.CSharp6.HelloWorld.Services.Calculator();

            
            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }
    }
}
