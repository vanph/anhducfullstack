using System;

namespace Lesson2.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Title { get; set; }

        public string TitleOfCourtesy { get; set; }

        public DateTime DateOfBirth {get; set;}

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostCode { get; set; }

        public string Country { get; set; }

        public string HomePhone { get; set; }
    }
}
