using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LinQExampleSelect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List< Student>dsSt = new List<Student>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSt.Add(new Student()
            {
                Id = "Student01",
                Name = "Ngo Hoang Lam",
                Email = "taihoa@gmail.com",
                Phone = "0987272782"
            });
            dsSt.Add(new Student()
            {
                Id = "Student02",
                Name = "Ngo Van Binh",
                Email = "taihoc@gmail.com",
                Phone = "0987279882"
            });
            dsSt.Add(new Student()
            {
                Id = "Student03",
                Name = "Vuong Hoc",
                Email = "hoc12hoa@gmail.com",
                Phone = "0927272782"
            });
            dsSt.Add(new Student()
            {
                Id = "Student04",
                Name = "Hoang ChiLam",
                Email = "ta32ihoa@gmail.com",
                Phone = "0987762782"
            });
            lvMain.Items.Clear();
            dsSt.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Id);
                lvi.SubItems.Add(x.Name);
                lvi.SubItems.Add(x.Email);
                lvi.SubItems.Add(x.Phone);
                lvMain.Items.Add(lvi);

            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dsFilter = dsSt.Select(x => new {x.Id, x.Name});
            dataGridView1.DataSource = dsFilter.ToList(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dsFilter = from x in dsSt
                select new {x.Id, x.Name};
            dataGridView1.DataSource = dsFilter.ToList();
        }
    }
}
