using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaterScienceApp
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 260;
            txtDisplay.Width = 220;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 510;
            txtDisplay.Width = 460;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 260;
            txtDisplay.Width = 220;
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 820;
            txtDisplay.Width = 460;
        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 820;
            txtDisplay.Width = 460;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Clear();
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + num.Text;
                }
                else
                {
                    txtDisplay.Text = txtDisplay.Text + num.Text;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
                
        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button) sender;
            operation = num.Text;
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            
        }
    }
}
