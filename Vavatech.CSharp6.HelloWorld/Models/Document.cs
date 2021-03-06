﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.CSharp6.HelloWorld.Models
{
    abstract class Document : Base
    {
        public int DocumentId { get; set; }

        public string Number { get; set; }

        public decimal Price { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("Initialize...");

            var tax = GetTax();

            Console.WriteLine($"Tax: {tax}");

            Archive();

        }

        public abstract decimal GetTax();


        public void Archive()
        {
            Console.WriteLine("archive");
        }
    }
}
