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
            //int b = a;//b=10
            //b = 15;
            // Console.WriteLine($"a = {a}, b ={b}");

            UpdateNumber(a);
           
            Console.WriteLine(a);
            
            //Test3();
            
            Console.ReadLine();
        }

        private static int UpdateNumber(int number)
        {
            number = number + 100;

            return number;
        }
        private static void Test3()
        {
            var emp1 = new Employee() { FirstName = "Ngo", LastName = "Anh Duc", Age = 30 };
            var emp2 = new Employee() { FirstName = "Pham", LastName = "Van", Age = 29 };
            var emp3 = new Employee() { FirstName = "Bui", LastName = "Quang Hieu", Age = 28 };

            var employees = new List<Employee> { emp1, emp2, emp3 };

            var count = employees.Count;

            Console.WriteLine("Total employee count:" + count);
            //i=0,1,2
            //for (int i = 0; i < count; i++)
            //{
            //    var emp = employees[i];
            //    emp.FirstName = "Duong";
            //}

            UpdateEmployeeList(employees);

            PrintEmployees(employees);

        }

        private static void UpdateEmployeeList(List<Employee> employeeList)
        {
            var count = employeeList.Count;

            for (int i = 0; i < count; i++)
            {
                var emp = employeeList[i];
                emp.FirstName = "Duong";
            }
        }


        private static void Test2()
        {
            var emp1 = new Employee() { FirstName = "Ngo", LastName = "Anh Duc", Age = 30 };
            var emp2 = new Employee() { FirstName = "Pham", LastName = "Van", Age = 29 };
            var emp3 = new Employee() { FirstName = "Bui", LastName = "Quang Hieu", Age = 28 };

            var employees = new List<Employee> {emp1, emp2, emp3};

            Console.WriteLine("Set up data:");

            PrintEmployees(employees);
            
            var emp4 = emp1;
            emp4.FirstName = "Nguyen";

            Console.WriteLine("Update data:");

            PrintEmployees(employees);

        }

        private static void PrintEmployees(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"Employee: {emp.FullName} at age: {emp.Age}");
            }
        }

        private static void Test1()
        {
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
        }
    }
}
