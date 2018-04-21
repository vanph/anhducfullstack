using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào họ tên");
                txtHoTen.Focus(); //Đưa con trỏ chuột về lại
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Email");
                txtEmail.Focus(); //Đưa con trỏ chuột về lại
            }
            else if (txtPhone.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Phone");
                txtPhone.Focus(); //Đưa con trỏ chuột về lại
            }
            else if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Tài khoản");
                txtTaiKhoan.Focus(); //Đưa con trỏ chuột về lại
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Mật khẩu");
                txtMatKhau.Focus(); //Đưa con trỏ chuột về lại
            }
            else if (txtXacNhanMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Xác nhận mật khẩu");
                txtXacNhanMatKhau.Focus(); //Đưa con trỏ chuột về lại
            }
        }
    }
}
