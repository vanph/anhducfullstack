using System;
using System.Windows.Forms;
using Hrm.App.Enumerations;

namespace Hrm.App.View
{
    public partial class DistrictListForm : Form
    {

        public DistrictListForm()
        {
            InitializeComponent();

        }


        private void btnSeach_Click(object sender, EventArgs e)
        {
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnClearSearch_click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (grdDistrict.SelectedRows.Count > 0)
            {

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmDetail = new DistrictDetailForm(EditMode.AddNew);
            var dialogResult = frmDetail.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show(@"Successfully added district", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grdDistrict.SelectedRows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show(@"Please select a district to edit", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (grdDistrict.SelectedRows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show(@"Please select a district to view details", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (grdDistrict.SelectedRows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show(@"Please select a district to delete", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbout = new AboutForm();
            frmAbout.ShowDialog();
        }


        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listCityForm = new CityListForm();
            listCityForm.ShowDialog();

        }


    }
}
