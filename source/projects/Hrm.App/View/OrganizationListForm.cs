using System;
using System.Linq;
using System.Windows.Forms;
using Hrm.App.ViewModel;
using Hrm.DataAccess;

namespace Hrm.App.View
{
    public partial class OrganizationListForm : Form
    {
       
        public OrganizationListForm()
        {
            InitializeComponent();
            grdOrg.AutoGenerateColumns = false;
        }

        private void OrganizationListForm_Load(object sender, EventArgs e)
        {
            var dbContext = new HrmEntities();
            var query = dbContext.Organizations.Select(x => new OrganizationViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Email = x.Email,
                Phone = x.Phone,
                //EmployeesCount = x.Employees.Count
            });

            var organizations = query.ToList();

            grdOrg.DataSource = organizations;
        }
    }
}
