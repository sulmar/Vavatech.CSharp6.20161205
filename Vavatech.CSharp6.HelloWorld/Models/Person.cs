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

        private short _Age;

        public short Age
        {
            get
            {
                return _Age;
            }

            set
            {
                if ((value > 0) && (value < 122))
                {
                   _Age = value;
                }
            }
        }

        //public short GetAge()
        //{
        //    return this.Age;
        //}

        //public void SetAge(short value)
        //{
        //    if ((value > 0) && (value < 122))
        //    { 
        //        this.Age = value;
        //    }
        //}

      

        public string FullName 
        {
            get
            {
                return $"{FirstName} {LastName} {Age}";
            }
        }
            

        public override string ToString()
        {
            return FullName;
        }
    }
}
