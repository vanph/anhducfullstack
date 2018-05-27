using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExistLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> listInt = new List<int>();
        private void ButtonCreateList_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            Random rd = new Random();
            listInt = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int x = rd.Next(100);
                listInt.Add(x);
            }
            lstN.Items.Clear();
            listInt.ForEach(x => lstN.Items.Add(x));
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            int k = int.Parse(txtFind.Text);
            bool rs = listInt.Exists(x => x == k);
            if (rs == true)
            {
                MessageBox.Show("Exist " + k + " in listN. ");
            }
            else
            {
                MessageBox.Show("ListN don't exist " + k + " ! ");
            }
        }
        List<Product> listProducts = new List<Product>();

        public void CreateFakeListProduct()
        {
            listProducts.Add(new Product() {ProductId = "SP1", ProductName = "Coca"});
            listProducts.Add(new Product() { ProductId = "SP2", ProductName = "Pepsi" });
            listProducts.Add(new Product() { ProductId = "SP3", ProductName = "Sting" });
            listProducts.Add(new Product() { ProductId = "SP4", ProductName = "REDBULL" });
        }

        private void Form_Load(object sender, EventArgs e)
        {
            CreateFakeListProduct();
            listProducts.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem((listView1.Items.Count + 1) + "");
                lvi.SubItems.Add(x.ProductId);
                lvi.SubItems.Add(x.ProductName);
                listView1.Items.Add(lvi);
            });
        }

        private void ButtonFindProduct_Click(object sender, EventArgs e)
        {
            bool rs = listProducts.Exists(x => x.ProductName == txtNameProduct.Text);
            if (rs == true)
            {
                MessageBox.Show("Have product [" + txtNameProduct.Text + "] in list products");
            }
            else
            {
                MessageBox.Show("Don't have product [" + txtNameProduct.Text + "] in list products");
            }
        }
    }
}
