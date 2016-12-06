using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.CSharp6.HelloWorld.Models
{
    abstract class Document
    {
        public int DocumentId { get; set; }

        public string Number { get; set; }

        public decimal Price { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("Initialize...");
        }
    }
}
