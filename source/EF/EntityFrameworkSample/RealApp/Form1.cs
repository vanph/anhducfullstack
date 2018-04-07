using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealApp.Models;

namespace RealApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dbContext  = new HRMEntities();
            var organizations = dbContext.Organizations.ToList();
            dataGridView1.DataSource = organizations;
        }
    }
}
