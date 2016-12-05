using System;
using My = Vavatech.CSharp6.Logic;
// C# 6.0
using static System.Math;
using static System.Console;
using Vavatech.CSharp6.HelloWorld.Models;
using System.Collections;
using System.Collections.Generic;

namespace Vavatech.CSharp6.HelloWorld
{
    
    class Program
    {
        static void Main(string[] args)
        {
            GenericTest();

            GenericListTest();

            ArrayListTest();

            ArrayTest();

            Cast2Test();

            CastTest();


            Var2Test();

            VarTest();


            ParameterOutTest();


            CalculateAddTest();

            // CalculateTest();

            WriteLine("Press any key to exit.");

            ReadKey();
        }

        private static void GenericTest()
        {
            var printer = new Printer();

            printer.Print<string>("Hello");
            printer.Print<DateTime>(DateTime.Now);

            var person = new Person { FirstName = "Marcin" };
            printer.Print<Person>(person);

        }

        private static void GenericListTest()
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person { FirstName = "Marcin" });

            persons.Add(new Person { FirstName = "Marcin" });

            persons.Add(new Person { FirstName = "Leszek" });

            persons.Add(new Person { FirstName = "Leszek" });

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }

        private static void ArrayListTest()
        {
            ArrayList persons = new ArrayList(3);

            persons.Add(new Person { FirstName = "Marcin" });

            persons.Add(new Person { FirstName = "Marcin" });

            persons.Add(new Person { FirstName = "Leszek" });

            persons.Add(new Person { FirstName = "Leszek" });

            persons.Add(800);

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }

        private static void ArrayTest()
        {

            // C# 6.0
            int[] array = { 10, 5, 0, 5 };


            int number = array[3];

            Console.WriteLine(number);


            Person[] persons = 
            {
                new Person {FirstName = "Marcin" },
                new Person {FirstName = "Marcin" },
                new Person {FirstName = "Leszek" },
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }

        }

        private static void Cast2Test()
        {
            var person = new Person
            {
                FirstName = "Marcin",
                LastName = "Sulecki",
                Weight = 10,
                Age = 18,
            };

            // zła praktyka
            try
            {
                Person person2 = (Person)person;
                Console.WriteLine(person2);
            }
            catch(InvalidCastException e)
            {

            }
            
            // dobra praktyka
            Person person3 = person as Person; 

            if (person3 != null)
            {
                Console.WriteLine(person3);
            }


        }

        private static void CastTest()
        {
            int x = 10;

            long y = 29;

            x = (int) y;


            // Uwaga: inne wyniki!
            double result1 = x / 3;

            double result2 = x / 3d;

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
            var person = new Person
            {
                FirstName = "Marcin",
                LastName = "Sulecki",
                Weight = 10,
                Age = 18,
            };

            // Klasa anonimowa
            var personInfo = new
            {
                Imie = person.FirstName,
                Nazwisko = person.LastName,
                Wiek = person.Weight,
            };

            Console.WriteLine($"{personInfo.Imie} {personInfo.Nazwisko}");

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
