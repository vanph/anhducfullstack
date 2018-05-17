using System;
using System.Linq;
using System.Windows.Forms;
using Hrm.App.Enumerations;
using Hrm.App.ViewModel;
using Hrm.DataAccess;

namespace Hrm.App.View
{
    public sealed partial class EmployeeDetailForm : Form
    {
        private readonly EditMode _editMode;
        private readonly string _selectedCode;

        public EmployeeDetailForm(EditMode editMode, string code = "")
        {
            InitializeComponent();


            _editMode = editMode;

            if (_editMode != EditMode.AddNew)
            {
                _selectedCode = code;

            }

            switch (editMode)
            {
                case EditMode.AddNew:
                    Text = @"Add new District";
                    break;
                case EditMode.Edit:
                    Text = @"Edit District";
                    break;
                case EditMode.View:
                    Text = @"View District Details";
                    break;
            }

        
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
          

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
