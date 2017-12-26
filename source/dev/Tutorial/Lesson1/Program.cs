using Lesson1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{    
    class Program
    {
        static void Main(string[] args)
        {
            //emp : object, instance
            var emp1 = new Employee
            {
                FirstName = "Ngo",
                LastName = "Anh Duc",
                Gender = "Male",
                BirthOfDate = new DateTime(1984, 12,1)
            };

            //Console.WriteLine(string.Format("Fullname: {0} {1} - Gender: {2}", emp.FirstName, emp.LastName, emp.Gender));
            //Console.WriteLine($"Fullname: {emp1.FirstName} {emp1.LastName} - Gender: {emp1.Gender}");

            var emp2 = new Employee
            {
                FirstName = "Nguyen",
                LastName = "Anh Huy",
                Gender = "Male",
                BirthOfDate = new DateTime(1988, 12, 1)
            };

           
            var employees = new List<Employee>();

            employees.Add(emp1);
            employees.Add(emp2);
            
             //var count = employees.Count;

            //for(int i=0; i< count; i++)
            //{
            //    var emp = employees[i];
            //    Console.WriteLine($"Fullname: {emp.FirstName} {emp.LastName} - Gender: {emp.Gender}");
            //}

            foreach(var emp in employees)
            {
                Console.WriteLine($"Fullname: {emp.FirstName} {emp.LastName} - Gender: {emp.Gender} - DoB: {emp.BirthOfDate.ToShortDateString()}");
            }

            Console.ReadLine();
            
        }
    }
}
