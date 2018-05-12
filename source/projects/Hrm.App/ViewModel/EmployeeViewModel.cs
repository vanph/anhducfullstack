using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.App.ViewModel
{
    public class EmployeeViewModel
    {
        public Guid Id { get; set; }

        public int OrganizationId { get; set; }

        public string Code { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }
        
        public string Email { get; set; }

        public DateTime? Dob { get; set; }

        #region Calculated Property

        public string FullName => $"{FirstName} {MiddleName} {LastName}";

        #endregion

    }
}
