using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My = Vavatech.CSharp6.Logic;
using Services = Vavatech.CSharp6.HelloWorld.Services;
// C# 6.0
using static System.Math;
using static System.Console;

namespace Vavatech.CSharp6.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");

            WriteLine("Podaj imię");

            string firstname = ReadLine();

            WriteLine("Podaj nazwisko");

            string lastname = ReadLine();

            double weight = 10.123;

            // C# 6.0 Interpolacja
            string fullname = $"{firstname} {lastname} {weight:N2} {DateTime.Now:yyyy-MM-dd HH.mm}";

            WriteLine(fullname);

            Services.Calculator calculator1 = new Services.Calculator();

            My.Calculator calculator2 = new My.Calculator();


            double result = Sqrt(Sin(weight));

            
            WriteLine("Press any key to exit.");

            ReadKey();
        }
    }
}
