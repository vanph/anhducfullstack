using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;//b=10
            b = 15;

            //a? , b?

            Console.WriteLine($"a = {a}, b ={b}");

            var emp1 = new Employee() {FirstName = "Duc", LastName = "Ngo", Age = 30};

            var emp2 = emp1;
            Console.WriteLine("Before:");
            Console.WriteLine($"Emp1: {emp1.FirstName} - {emp1.LastName} - {emp1.Age}");
            Console.WriteLine($"Emp2: {emp2.FirstName} - {emp2.LastName} - {emp2.Age}");


            emp2.FirstName = "Van";
            emp2.Age = 12;

            //emp1? emp2 ?

            Console.WriteLine("After changed emp2:");
            Console.WriteLine($"Emp1: {emp1.FirstName} - {emp1.LastName} - {emp1.Age}");
            Console.WriteLine($"Emp2: {emp2.FirstName} - {emp2.LastName} - {emp2.Age}");

            Console.ReadLine();
        }
    }
}
