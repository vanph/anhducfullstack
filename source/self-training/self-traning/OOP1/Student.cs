using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Student
    {
        #region các biến lớp
        private string ten;
        private int ma;
        #endregion
        #region các contructor
        public Student()
        {
            this.ma = 1;
            this.ten = "Ten gi do";
        }

        public Student(int ma, string ten)
        {
            this.ma = ma;
            this.ten = ten;
        }
        #endregion
        #region các properties
        public int Ma
        {
            get { return this.ma; }
            set { this.ma = value; }
        }

        public string Ten
        {
            get => this.ten;
            set => this.ten = value;
        }
        #endregion
        #region các phương thức
        public override string ToString()
        {
            return this.ma + "\t" + this.ten;
        }
        #endregion

    }
}
