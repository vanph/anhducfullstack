using System;

namespace EmployeeSite.Models
{
    public class Employee
    {
        public string FirstName {get;set;} //auto-property

        public int EmployeeId { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string TitleOfCourtesy { get; set; }

        public DateTime DateOfBirth {get; set;}

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostCode { get; set; }

        public string Country { get; set; }

        public string HomePhone { get; set; }

        //Calculated Property | Read only
        public string FullNameWithTitle
        {
            get
            {
                return $"{TitleOfCourtesy} {FirstName} {LastName}";
            }
           
        }

        public string FullAddress
        {
            get { return $"{Address}, {City}, {Region}, {Country}"; }
        }

        //public string FullNameWithTitle => $"{TitleOfCourtesy} {FirstName} {LastName}"; //expresion-bodied property

      
        public string GetEmployeeDescription()
        {
            return $"{EmployeeId} | {FullNameWithTitle} - {Title} | {DateOfBirth.ToShortDateString()} | {FullAddress} | {HomePhone}";
        }
    }
}
