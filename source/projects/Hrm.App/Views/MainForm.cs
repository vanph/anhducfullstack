using System;
using System.Linq;
using System.Windows.Forms;
using Hrm.App.Enumerations;
using Hrm.App.Models;
using Hrm.DataAccess;

namespace Hrm.App.Views
{
    public partial class MainForm : Form
    {
        private readonly HrmEntities _dbContext;
        public MainForm()
        {
            InitializeComponent();

            lblCode.Text = "";
            lblFullName.Text = "";
            lblEmail.Text = "";
            lblDob.Text = "";

            grdEmployees.AutoGenerateColumns = false;
            _dbContext = new HrmEntities();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchEmployees();
        }

        private void SearchEmployees()
        {
            //var query = from emp in dbContext.Employees
                        //            join org in dbContext.Organizations on emp.OrganizationId equals org.Id
                        //            select new EmployeeModel()
                        //            {
                        //                Id = emp.Id,
                        //                OrganizationId = emp.OrganizationId,
                        //                Code = emp.Code,
                        //                Email = emp.Email,
                        //                FirstName = emp.FirstName,
                        //                MiddleName = emp.MiddleName,
                        //                LastName = emp.LastName,
                        //                Dob = emp.Dob,
                        //                OrganizationName = org.Name
                        //            };

                        //grdEmployees.DataSource = query.ToList();

            //Lazy loading

            var employeeModels = _dbContext.Employees.Select(x => new EmployeeModel()
            {
                Id = x.Id,
                OrganizationId = x.OrganizationId,
                Code = x.Code,
                Email = x.Email,
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName,
                Dob = x.Dob,
                OrganizationName = x.Organization.Name
            }).OrderBy(x => x.Code).ToList();

            grdEmployees.DataSource = employeeModels;
        }

        private void ButtonClearSearch_Click(object sender, EventArgs e)
        {

        }

        private void GridViewEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (grdEmployees.SelectedRows.Count > 0)
            {
                var empViewModel = grdEmployees.SelectedRows[0].DataBoundItem as EmployeeModel;

                if (empViewModel != null)
                {
                    lblCode.Text = empViewModel.Code;
                    lblFullName.Text = empViewModel.FullName;
                    lblEmail.Text = empViewModel.Email;
                    lblDob.Text = empViewModel.Dob.HasValue ? empViewModel.Dob.Value.ToShortDateString() : string.Empty;
                }

            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var frmDetail = new EmployeeDetailForm(EditMode.AddNew);

            var dialogResult =  frmDetail.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show(@"Successfully added employee", @"Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                SearchEmployees();
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (grdEmployees.SelectedRows.Count > 0)
            {
                var empEditModel = grdEmployees.SelectedRows[0].DataBoundItem as EmployeeModel;

                if (empEditModel != null)
                {
                    var frmDetail = new EmployeeDetailForm(EditMode.Edit);
                    frmDetail.SelectedEmployee = empEditModel;

                   var  dialogResult = frmDetail.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        MessageBox.Show(@"Successfully updated the employee", @"Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        SearchEmployees();
                    }
                }
                
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
                var empViewModel = grdEmployees.SelectedRows[0].DataBoundItem as EmployeeModel;

                if (empViewModel != null)
                {
                    var frmDetail = new EmployeeDetailForm(EditMode.View);
                    frmDetail.SelectedEmployee = empViewModel;

                    frmDetail.ShowDialog();
                }
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
                var empViewModel = grdEmployees.SelectedRows[0].DataBoundItem as EmployeeModel;

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
