using System;

namespace Hrm.App.Models
{
    public class EmployeeModel
    {
        public Guid Id { get; set; }

        public int OrganizationId { get; set; }

        public string Code { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }
        
        public string Email { get; set; }

        public DateTime? Dob { get; set; }

        public string OrganizationName {get; set;}

        #region Calculated Property

        public string FullName => $"{FirstName} {MiddleName} {LastName}";

        #endregion

    }
}
