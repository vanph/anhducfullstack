using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerApp
{
    public class Department
    {
        private List<Employees> ListOfEmployees = new List<Employees>();
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public Employees Manager { get; set; }
    }
}
