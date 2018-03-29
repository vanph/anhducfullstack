using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqExampleWhere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> dsSt = new List<Student>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSt.Add(new Student()
            {
                Id = "1",
                Name = "Vu Hoang",
                Email = "hoang12@yahoo.com",
                Phone = "0118782829"
            });
            dsSt.Add(new Student()
            {
                Id = "2",
                Name = "Hoang Long",
                Email = "cuong@gmail.com",
                Phone = "01187823334"
            });
            dsSt.Add(new Student()
            {
                Id = "3",
                Name = "Luong Khanh",
                Email = "vuthanh@yahoo.com",
                Phone = "01187321829"
            });
            dsSt.Add(new Student()
            {
                Id = "4",
                Name = "Cung Le",
                Email = "xuongrong@gmail.com",
                Phone = "0118782889"
            });
            dsSt.Add(new Student()
            {
                Id = "5",
                Name = "Dai Vu",
                Email = "hhuong2@yahoo.com",
                Phone = "0818192829"
            });

            lvMain.Items.Clear();
            dsSt.ForEach(st =>
            {
                ListViewItem lvi = new ListViewItem(st.Id);
                lvi.SubItems.Add(st.Name);
                lvi.SubItems.Add(st.Email);
                lvi.SubItems.Add(st.Phone);
                lvMain.Items.Add(lvi);

            });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var dsFilter = dsSt
                .Where(st => st.Phone.StartsWith(txtDauSo.Text))
                .ToList();
            dgvStudent.DataSource = dsFilter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dsFilter = from st in dsSt
                where st.Phone.StartsWith(txtDauSo.Text)
                select st;
            dgvStudent.DataSource = dsFilter.ToList();
        }
    }
}
