using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForeachLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonForeach_Click(object sender, EventArgs e)
        {
            List<int>  listInt = new List<int>();
            Random rd = new Random();
            int n = int.Parse(txtN.Text);
            for (int i = 0; i < n; i++)
            {
                listInt.Add(rd.Next(100));
            }
            lstN.Items.Clear();
            //foreach cua linq
            listInt.ForEach(x => //=> la lambda expression
            {
                lstN.Items.Add(x);
            });

            //cách 2 tách riêng hàm
            //listInt.ForEach(x =>
            //{
            //    AddValue(x);
            //});

            //foreach binh thuong
            //foreach (int x in listInt)
            //{
            //    lstN.Items.Add(x);
            //}
        }

        public void AddValue(int x)
        {
            lstN.Items.Add(x);
        }
        
        List<Product> listProduct = new List<Product>();
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductId = txtProductId.Text;
            product.ProductName = txtProductName.Text;
            listProduct.Add(product);
            ProductDisplay();
        }

        public void ProductDisplay()
        {
            lvProduct.Items.Clear(); //xóa dữ liệu cũ trên giao diện
            // cách viết hàm tường minh (xây dựng hàm riêng rồi gọi hàm ra)
//            listProduct.ForEach(x => ProductOneDisplay(x));
            // cách viết anonymous methob
            listProduct.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.ProductId);
                lvi.SubItems.Add(x.ProductName);
                lvProduct.Items.Add(lvi);
            });
        }

        public void ProductOneDisplay(Product product)
        {
            ListViewItem lvi = new ListViewItem(product.ProductId);
            lvi.SubItems.Add(product.ProductName);
            lvProduct.Items.Add(lvi);
        }
    }
}
