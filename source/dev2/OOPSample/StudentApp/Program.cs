using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp.Models;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student
            {
                FirstName = "Duc",
                LastName = "Ngo",
                Age = 20
            };

            student.Greet();
            student.GoToClasses();
            student.ShowAge();
            
            var teacher = new Teacher
            {
                FirstName = "Park",
                LastName = "Hang Seo",
                Age = 50
            };

            teacher.Greet();
            teacher.Explain();

            Console.ReadLine();
        }
    }
}
