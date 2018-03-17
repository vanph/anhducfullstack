using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm
{
    class User
    {
        private string hoten, email, phone, taikhoan, matkhau;

        public User()
        {
            hoten = email = phone = taikhoan = matkhau = "";
        }

        public User(string ten, string mail, string didong, string tk, string mk)
        {
            hoten = ten;
            email = mail;
            phone = didong;
            taikhoan = tk;
            matkhau = mk;
        }
    }
}
