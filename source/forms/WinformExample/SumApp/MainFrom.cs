using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumApp
{
    public partial class MainFrom : Form
    {

        public MainFrom()
        {
            InitializeComponent();
            lblResult.Text = string.Empty;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            lblResult.Text = string.Empty;
            int number1;
            var number1Valid = int.TryParse(txtNumber1.Text, out number1);

            int number2;
            var number2Valid = int.TryParse(txtNumber2.Text, out number2);

            if (number1Valid && number2Valid)
            {
                lblResult.Text = (number1 + number2).ToString();
                return;
                
            }

            if(!number1Valid && !number2Valid)
            {
                MessageBox.Show(@"Please input correct Number 1 and Number 2");
                return;
            }

            MessageBox.Show(!number2Valid ? @"Please input correct Number 2" : @"Please input correct Number 1");
        }

      
    }
}
