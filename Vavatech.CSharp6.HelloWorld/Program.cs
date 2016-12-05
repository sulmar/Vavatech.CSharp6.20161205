using System;
using My = Vavatech.CSharp6.Logic;
// C# 6.0
using static System.Math;
using static System.Console;
using Vavatech.CSharp6.HelloWorld.Models;

namespace Vavatech.CSharp6.HelloWorld
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Var2Test();

            VarTest();


            ParameterOutTest();


            CalculateAddTest();

            // CalculateTest();

            WriteLine("Press any key to exit.");

            ReadKey();
        }

        private static void VarTest()
        {
            var x = 10.5m;

            // x = "Hello";


            Console.WriteLine(x);
        }


        private static void Var2Test()
        {
            // Inicjalizator
            Person person = new Person
            {
                FirstName = "Marcin",
                LastName = "Sulecki",
                Weight = 10,
                Age = 18,
            };

            PersonInfo personInfo = new PersonInfo();
            personInfo.FirstName = person.FirstName;
            personInfo.LastName = person.LastName;

            Console.WriteLine($"{personInfo.FirstName} {personInfo.LastName}");

        }

        private static void ParameterOutTest()
        {

            Services.Calculator calculator = new Services.Calculator();

            int result;

            if (calculator.TryAdd(99, 5, out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Wynik poza zakresem");
            }
        }

        private static void CalculateAddTest()
        {
            Services.Calculator calculator = new Services.Calculator();

            int result = calculator.Add(10, 5, description: "Opis");

            WriteLine($"Result: {result}");
        }

        private static void CalculateTest()
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

            double result = Sin(weight);

            WriteLine($"Rezultat: {result}");
        }

        private static void CalculatorTest()
        {

        }
    }


}
