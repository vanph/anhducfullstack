using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSales
{
    public partial class Form1 : Form
    {
        ListOfCustomers database = new ListOfCustomers();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCharged_Click(object sender, EventArgs e)
        {
            Customers cs = new Customers();
            cs.Name = txtName.Text;
            cs.NumberBuy = int.Parse(txtNumber.Text);
            cs.IsStudent = chkIsStudent.Checked;
            database.Buy(cs);
            lblTotalMoney.Text = cs.Charged + "";

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtNumber.Text = "";
            chkIsStudent.Checked = false;
            lblTotalMoney.Text = "";
            txtName.Focus();
        }

        private void ButtonStatistic_Click(object sender, EventArgs e)
        {
            txtTotalCustomer.Text = database.TotalCustomers + "";
            txtTotalIsStudent.Text = database.TotalCustomersIsStudent + "";
            txtTotalRevenue.Text = database.TotalRevenue + "";
        }

        private void TextTotalCustomer_DoubleClick(object sender, MouseEventArgs e)
        {
            Form frm = new Form();
            frm.Width = frm.Height = 300;
            ListBox lstCustomer = new ListBox();
            frm.Controls.Add(lstCustomer);
            lstCustomer.Dock = DockStyle.Fill;
            foreach(Customers cs in database.Customer)
            {
                lstCustomer.Items.Add(cs.Name);
            }
            frm.Show();
        }
    }
}
