using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthwindApp1.Models;

namespace NorthwindApp1
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
            var query = dbContext.Orders;
            var query1 = dbContext.Products;
            var orders = query.ToList();
            dataGridView1.DataSource = orders;
            var products = query1.ToList();
            dataGridView2.DataSource = products;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dbContext = new NorthwindEntities();

            var keyword = textBox1.Text;

            var query1 = dbContext.Products as IQueryable<Product>;

            if (!string.IsNullOrEmpty(keyword))
            {
                query1 = query1.Where(y => y.ProductName.Contains(keyword) || y.QuantityPerUnit.Contains(keyword));
            }

            dataGridView2.DataSource = query1.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dbContext = new NorthwindEntities();

            var keyword = textBox1.Text;

            var query = dbContext.Orders as IQueryable<Order>;

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.ShipName.Contains(keyword) || x.ShipAddress.Contains(keyword));
            }
            dataGridView1.DataSource = query.ToList();
        }
    }
}
