using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Hrm.App.Enumerations;
using Hrm.App.ViewModel;
using Hrm.DataAccess;

namespace Hrm.App.View
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            lblCode.Text = "";
            lblFullName.Text = "";
            lblEmail.Text = "";
            lblDob.Text = "";

            grdEmployees.AutoGenerateColumns = false;
          
        }



        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var dbContext = new HrmEntities();

            var employeeViewModels = dbContext.Employees.Select(x => new EmployeeViewModel()
            {
                Id = x.Id,
                OrganizationId = x.OrganizationId,
                Code = x.Code,
                Email = x.Email,
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName,
                Dob = x.Dob
            }).OrderBy(x=> x.Code).ToList();

            grdEmployees.DataSource = employeeViewModels;
        }

        private void ButtonClearSearch_Click(object sender, EventArgs e)
        {

        }

        private void GridViewEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (grdEmployees.SelectedRows.Count > 0)
            {
                var empViewModel = grdEmployees.SelectedRows[0].DataBoundItem as EmployeeViewModel;

                if (empViewModel != null)
                {
                    lblCode.Text = empViewModel.Code;
                    lblFullName.Text = empViewModel.FullName;
                    lblEmail.Text = empViewModel.Email;
                    lblDob.Text = empViewModel.Dob.HasValue? empViewModel.Dob.Value.ToShortDateString(): string.Empty;
                }

            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var frmDetail = new EmployeeDetailForm(EditMode.AddNew);

            frmDetail.ShowDialog();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (grdEmployees.SelectedRows.Count > 0)
            {
                var frmDetail = new EmployeeDetailForm(EditMode.Edit);

                frmDetail.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"Please select an employee to edit", @"Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
               
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            if (grdEmployees.SelectedRows.Count > 0)
            {
                var frmDetail = new EmployeeDetailForm(EditMode.View);

                frmDetail.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"Please select an employee to view", @"Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (grdEmployees.SelectedRows.Count > 0)
            {
                var empViewModel = grdEmployees.SelectedRows[0].DataBoundItem as EmployeeViewModel;

                if (empViewModel != null)
                {
                    var dialogResult = MessageBox.Show($@"Do you want to delete the employee {empViewModel.Code}?",
                        @"Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show(@"to implement later");
                    }

                }
            }
            else
            {
                MessageBox.Show(@"Please select an employee to view", @"Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }  

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbout = new AboutForm();
            frmAbout.ShowDialog();
        }
    }
}
