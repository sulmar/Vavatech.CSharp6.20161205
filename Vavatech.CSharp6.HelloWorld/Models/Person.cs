using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.CSharp6.HelloWorld.Models
{
    class Person
    {
        public string FirstName;

        public string LastName;

        public double Weight;

        public short Age;

        public string FullName 
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
            

        public override string ToString()
        {
            return FullName;
        }
    }
}
