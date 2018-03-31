using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthwindApp.Models;

namespace NorthwindApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dbContext = new NorthwindEntities();
            //var date = new DateTime(1960,1,1);

            //var query = dbContext.Employees.Where(x=>x.BirthDate > date).OrderBy(x => x.LastName);

            //  var query = dbContext.Employees.Select(x=> new {x.LastName, x.FirstName,x.Address,x.City}).OrderBy(x => x.LastName);
            var query = dbContext.Employees;
            var employees = query.ToList();
            dataGridView1.DataSource = employees;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var dbContext = new NorthwindEntities();
            
            var keyword = txtKeyword.Text;

            var query =  dbContext.Employees as IQueryable<Employee>;
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.LastName.Contains(keyword) || x.FirstName.Contains(keyword));
            }

            dataGridView1.DataSource = query.ToList();

        }
    }
}
