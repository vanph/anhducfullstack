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
            //int a = 10;
            //int b = a;//b=10
            //b = 15;

            //a = 10 , b = 15 

            // Console.WriteLine($"a = {a}, b ={b}");

            var emp1 = new Employee() { FirstName = "Ngo", LastName = "Anh Duc", Age = 30 };

            var emp2 = emp1;
            Console.WriteLine("Before:");
            Console.WriteLine($"Emp1: {emp1.FullName} at age: {emp1.Age}");
            Console.WriteLine($"Emp2: {emp2.FullName} at age: {emp2.Age}");


            emp2.FirstName = "Pham";
            emp2.Age = 25;

            ////emp1? emp2 ?

            Console.WriteLine("After changed emp2:");
            Console.WriteLine($"Emp1: {emp1.FullName} at age: {emp1.Age}");
            Console.WriteLine($"Emp2: {emp2.FullName} at age: {emp2.Age}");

            var emp3 = emp2;
            emp3.LastName = "Van";

            Console.WriteLine("After changed emp3:");
            Console.WriteLine($"Emp1: {emp1.FullName} at age: {emp1.Age}");
            Console.WriteLine($"Emp2: {emp2.FullName} at age: {emp2.Age}");
            Console.WriteLine($"Emp3: {emp3.FullName} at age: {emp3.Age}");

            Console.ReadLine();
        }
    }
}
