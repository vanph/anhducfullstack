using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class Teacher : Person
    {
        public Teacher(string firstname, string lastname):base(firstname,lastname)
        {
           
        }
        public void ShowTeacherInfo()
        {
            var age = GetAge();
            Console.WriteLine($"Teacher: {FirstName} {LastName} Age: {age}");
        }
    }
}
