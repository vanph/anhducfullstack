using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples01
{
    class OfficialEmployee:Employee
    {
        public new void Payroll()
        {
            base.Payroll();
            Console.WriteLine("Day la phuong thuc tinh luong cua nhan vien chinh thuc");
        }

        public override int Payroll(int PaidDaily)
        {
            if (PaidDaily == 20)
            {
                return 10000000;
            }
            return base.Payroll(PaidDaily);
        }
    }
}
