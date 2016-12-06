using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.CSharp6.HelloWorld.Models
{
    class Correction : Document
    {

        public override void Print()
        {
            Console.WriteLine("Init 1");

            Console.WriteLine("Init 2");

            base.Print();



            Console.WriteLine($"Printing...ID: {DocumentId}");
        }


        public override decimal GetTax()
        {
            return 100;
        }

        public new void Archive()
        {
            Console.WriteLine("Archive Correction");
        }
    }
}
