using System;
using System.Collections.Generic;
using Lesson2.Models;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee
            {
                EmployeeId = 1,
                LastName = "Davolio",
                FirstName = "Nancy",
                Title = "Sales Representative",
                TitleOfCourtesy = "Ms.",
                DateOfBirth = new DateTime(1948, 12, 8),
                Address = "507 - 20th Ave. E.Apt. 2A",
                City = "Seattle",
                Region = "WA",
                PostCode = "98122",
                Country = "USA",
                HomePhone = "(206) 555-9857"
            };

            var employee2 = new Employee
            {
                EmployeeId = 2,
                LastName = "Fuller",
                FirstName = "Andrew",
                Title = "Vice President, Sales",
                TitleOfCourtesy = "Dr.",
                DateOfBirth = new DateTime(1952, 2, 19),
                Address = "908 W. Capital Way",
                City = "Seattle",
                Region = "WA",
                PostCode = "98122",
                Country = "USA",
                HomePhone = "(206) 555-9482"
            };

            var employee3 = new Employee
            {
                EmployeeId = 3,
                LastName = "Leverling",
                FirstName = "Janet",
                Title = "Sales Representative",
                TitleOfCourtesy = "Ms.",
                DateOfBirth = new DateTime(1963, 8, 30),
                Address = "722 Moss Bay Blvd.",
                City = "Seattle",
                Region = "WA",
                PostCode = "98122",
                Country = "USA",
                HomePhone = "(206) 555-3412"
            };

            var employee4 = new Employee
            {
                EmployeeId = 4,
                LastName = "Peacock",
                FirstName = "Margaret",
                Title = "Sales Representative",
                TitleOfCourtesy = "Mrs.",
                DateOfBirth = new DateTime(1937, 9, 19),
                Address = "4110 Old Redmond Rd.",
                City = "Seattle",
                Region = "WA",
                PostCode = "98122",
                Country = "USA",
                HomePhone = "(206) 555-8122"
            };

            var employee5 = new Employee
            {
                EmployeeId = 5,
                LastName = "Buchanan",
                FirstName = "Steven",
                Title = "Sales Manager",
                TitleOfCourtesy = "Mr.",
                DateOfBirth = new DateTime(1955, 3, 4),
                Address = "14 Garrett Hill",
                City = "Seattle",
                Region = "WA",
                PostCode = "98122",
                Country = "USA",
                HomePhone = "(71) 555-4848"
            };

            var employee6 = new Employee
            {
                EmployeeId = 6,
                LastName = "Suyama",
                FirstName = "Michael",
                Title = "Sales Representative",
                TitleOfCourtesy = "Mr.",
                DateOfBirth = new DateTime(1963, 7, 2),
                Address = "Coventry HouseMiner Rd.",
                City = "Seattle",
                Region = "WA",
                PostCode = "98122",
                Country = "USA",
                HomePhone = "(71) 555-7773"
            };

            var employee7 = new Employee
            {
                EmployeeId = 7,
                LastName = "King",
                FirstName = "Robert",
                Title = "Sales Representative",
                TitleOfCourtesy = "Mr.",
                DateOfBirth = new DateTime(1960, 5, 29),
                Address = "Edgeham HollowWinchester Way",
                City = "Seattle",
                Region = "WA",
                PostCode = "98122",
                Country = "USA",
                HomePhone = "(71) 555-5598"
            };

            var employee8 = new Employee
            {
                EmployeeId = 8,
                LastName = "Callahan",
                FirstName = "Laura",
                Title = "Inside Sales Coordinator",
                TitleOfCourtesy = "Ms.",
                DateOfBirth = new DateTime(1958, 1, 9),
                Address = "4726 - 11th Ave. N.E.",
                City = "Seattle",
                Region = "WA",
                PostCode = "98122",
                Country = "USA",
                HomePhone = "(206) 555-1189"
            };

            var employee9 = new Employee
            {
                EmployeeId = 9,
                LastName = "Dodsworth",
                FirstName = "Anne",
                Title = "Sales Representative",
                TitleOfCourtesy = "Ms.",
                DateOfBirth = new DateTime(1966, 1, 27),
                Address = "7 Houndstooth Rd.",
                City = "Seattle",
                Region = "WA",
                PostCode = "98122",
                Country = "USA",
                HomePhone = "(71) 555-4444"
            };

            var employees = new List<Employee>
            {
                employee1,
                employee2,
                employee3,
                employee4,
                employee5,
                employee6,
                employee7,
                employee8,
                employee9
            };
            
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.EmployeeId} | {employee.FirstName} | {employee.LastName} | {employee.Title} | {employee.TitleOfCourtesy} | {employee.DateOfBirth.ToShortDateString()} | {employee.Address}| {employee.City}| {employee.Region} | {employee.PostCode} | {employee.Country} | {employee.HomePhone}");
            }

            Console.ReadLine();
            
        }
    }
}
