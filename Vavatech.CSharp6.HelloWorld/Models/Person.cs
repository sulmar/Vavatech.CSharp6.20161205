using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.CSharp6.HelloWorld.Models
{
    class Person
    {
        public int PersonId { get; set; }

        private string _FirstName;

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }


        public string LastName { get; set; }



        public double Weight;

        #region Age

        private short _Age { get; set; }

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

        #endregion

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
