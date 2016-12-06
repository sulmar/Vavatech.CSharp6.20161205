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

        public void Print()
        {
            Console.WriteLine("Printing...");


            if (this.GetType()==typeof(Invoice))
            {
                var invoice = (Invoice)this;
                Console.WriteLine($"Invoice DueDate: {invoice.DueDate}");
            }
            else
            if (this.GetType() == typeof(Bill))
            {
                var bill = (Bill)this;
                Console.WriteLine($"Bill PaymentType {bill.PaymentType}");
            }
        }
    }
}
