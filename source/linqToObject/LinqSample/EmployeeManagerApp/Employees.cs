using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerApp
{
    public class Employees
    {
        public const long BasicSalary = 10000000;

        public Employees(int employeesId, string employeesName, DateTime employeesDob, TypeOfPosition employeesPosition, Department department)
        {
            EmployeesId = employeesId;
            EmployeesName = employeesName;
            EmployeesDob = employeesDob;
            EmployeesPosition = employeesPosition;
            Department = department;
        }

        public int EmployeesId { get; set; }
        public string EmployeesName { get; set; }
        public DateTime EmployeesDob { get; set; }
        public TypeOfPosition EmployeesPosition { get; set; }
        public Department Department { get; set; }

        public long PayRoll
        {
            get
            {
                if (EmployeesPosition == TypeOfPosition.Derection)
                    return BasicSalary + (long)(BasicSalary * 0.25);
                if (EmployeesPosition == TypeOfPosition.Manager)
                    return BasicSalary + (long) (BasicSalary * 0.15);
                if (EmployeesPosition == TypeOfPosition.DeputyManager)
                    return BasicSalary + (long) (BasicSalary * 0.5);
                return BasicSalary;


            }
        }
    }
}
