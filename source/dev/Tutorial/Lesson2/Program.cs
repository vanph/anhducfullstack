using Lesson2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Employee1 = new ListEmployee
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

            var Employee2 = new ListEmployee
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

            var Employee3 = new ListEmployee
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

            var Employee4 = new ListEmployee
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

            var Employee5 = new ListEmployee
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

            var Employee6 = new ListEmployee
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

            var Employee7 = new ListEmployee
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

            var Employee8 = new ListEmployee
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

            var Employee9 = new ListEmployee
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
           
            var employees = new List<ListEmployee>();

        employees.Add(Employee1);
        employees.Add(Employee2);
        employees.Add(Employee3);
        employees.Add(Employee4);
        employees.Add(Employee5);
        employees.Add(Employee6);
        employees.Add(Employee7);
        employees.Add(Employee8);
        employees.Add(Employee9);


            foreach (var Employee in employees)
            {
                Console.WriteLine($"{Employee.EmployeeId} | {Employee.FirstName} | {Employee.LastName} | {Employee.Title} | {Employee.TitleOfCourtesy} | {Employee.DateOfBirth.ToShortDateString()} | {Employee.Address}| {Employee.City}| {Employee.Region} | {Employee.PostCode} | {Employee.Country} | {Employee.HomePhone}");
            }

            Console.ReadLine();


        }
    }
}
