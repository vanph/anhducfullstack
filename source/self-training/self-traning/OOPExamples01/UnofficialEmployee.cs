using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples01
{
    class UnofficialEmployee:Employee
    {
        public new void Payroll()
        {
            Console.WriteLine("Day la phuong thuc tinh luong cua nhan vien thoi vu");
        }
    }
}
