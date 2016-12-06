using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.CSharp6.HelloWorld.Models
{
    class Bill : Document
    {
        public string PaymentType { get; set; }


        public override void Print()
        {
            base.Print();

            Console.WriteLine($"Bill PaymentType {PaymentType}");
        }

        public override decimal GetTax()
        {
            return Price * 0.23m;
        }



    
    }
}
