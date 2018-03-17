using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodSample
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public  DateTime DoB { get; set; }

        public void Welcome()
        {
            Console.WriteLine($"Hello {FirstName} {LastName}");
        }
    }
}
