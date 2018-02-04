using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Models
{
    //public, private, protected: modifier
    public abstract class Person
    {
        public  string FirstName { get; set; } //auto-property

        public string LastName { get; set; } //auto-property
        
        public int Age { get; set; } //property

        public string FullName => $"{FirstName} {LastName}"; //calculated property

        public void Greet()
        {
            Console.WriteLine($"Hello! My name is {FullName}");
        }
    }
}
