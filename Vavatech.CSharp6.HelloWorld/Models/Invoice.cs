using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.CSharp6.HelloWorld.Models
{
    class Invoice : Document
    {
        public DateTime DueDate { get; set; }

        public override void Print()
        {
            base.Print();

            Console.WriteLine($"Invoice DueDate: {DueDate}");
        }
    }
}
