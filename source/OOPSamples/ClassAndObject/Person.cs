using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    //modifier
   public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public  DateTime Dob { get; set; }

        //Constructor
        //default
        public Person()
        {

        }

        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        //modifier: public, protected, private 
        public void PrintName()
        {
            var age = GetAge();
            Console.WriteLine($"Fullname: {FirstName} {LastName} - Age:{age}");
        }

        protected int GetAge()
        {
            return DateTime.Now.Year - Dob.Year;
        }
    }
}
