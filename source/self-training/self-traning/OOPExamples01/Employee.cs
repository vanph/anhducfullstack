using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples01
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Payroll()
        {
            Console.WriteLine("Day la phuong thuc tinh luong cua nhan vien");
        }

        public virtual int Payroll(int PaidDaily)
        {
            return PaidDaily * 100;
        }
    }
}
