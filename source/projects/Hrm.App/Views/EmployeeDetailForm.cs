using System;
using System.Linq;
using System.Windows.Forms;
using Hrm.App.Enumerations;
using Hrm.App.Models;
using Hrm.DataAccess;

namespace Hrm.App.Views
{
    public sealed partial class EmployeeDetailForm : Form
    {
        private readonly HrmEntities _dbContext;
        private readonly EditMode _editMode;
       
        public EmployeeModel SelectedEmployee { get; set; }
        public EmployeeDetailForm(EditMode editMode)
        {
            InitializeComponent();
            
            _editMode = editMode;

            _dbContext = new HrmEntities();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateControlValues(EmployeeModel emp)
        {
            txtCode.Text = emp.Code;
            txtFirstName.Text = emp.FirstName;
            txtMiddleName.Text = emp.MiddleName;
            txtLastName.Text = emp.LastName;
            txtEmail.Text = emp.Email;
            dtpDob.Value = emp.Dob.HasValue ? emp.Dob.Value : DateTime.Now;
        }

        private void EmployeeDetailForm_Load(object sender, EventArgs e)
        {
            switch (_editMode)
            {
                case EditMode.AddNew:
                    Text = @"Add new Employee";
                    break;
                case EditMode.Edit:
                    Text = @"Edit Employee";
                    UpdateControlValues(SelectedEmployee);

                    break;
                case EditMode.View:
                    Text = @"View Employee Details";
                    UpdateControlValues(SelectedEmployee);

                    txtCode.ReadOnly = true;
                    txtFirstName.ReadOnly = true;
                    txtMiddleName.ReadOnly = true;
                    txtLastName.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    dtpDob.Enabled = false;

                    btnSave.Visible = false;
                    btnCancel.Text = "OK";
                    
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_editMode == EditMode.AddNew)
                {
                    var employeeEntity = new Employee
                    {
                        Id= Guid.NewGuid(),
                        Code = txtCode.Text,
                        FirstName = txtFirstName.Text,
                        MiddleName = txtMiddleName.Text,
                        LastName = txtLastName.Text,
                        Email = txtEmail.Text,
                        Dob = dtpDob.Value,
                        CreatedBy = "admin",
                        CreatedDate = DateTime.Now,
                        ModifiedBy = "admin",
                        ModifiedDate = DateTime.Now,
                        OrganizationId = 1
                    };
                    
                    //todo: using combobox for organization

                    _dbContext.Employees.Add(employeeEntity);
                    _dbContext.SaveChanges();

                    DialogResult = DialogResult.OK;
                    
                }
                if (_editMode == EditMode.Edit)
                {
                    var existingEmployeeEntity = _dbContext.Employees.FirstOrDefault(x => x.Id == SelectedEmployee.Id);

                    if (existingEmployeeEntity != null)
                    {
                        existingEmployeeEntity.Code = txtCode.Text;
                        existingEmployeeEntity.FirstName = txtFirstName.Text;
                        existingEmployeeEntity.MiddleName = txtMiddleName.Text;
                        existingEmployeeEntity.LastName = txtLastName.Text;
                        existingEmployeeEntity.Email = txtEmail.Text;
                        existingEmployeeEntity.Dob = dtpDob.Value;
                        existingEmployeeEntity.ModifiedBy = "admin";
                        existingEmployeeEntity.ModifiedDate = DateTime.Now;
                        //existingEmployeeEntity.OrganizationId = 1

                        _dbContext.SaveChanges();

                        DialogResult = DialogResult.OK;
                    }
                }
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
