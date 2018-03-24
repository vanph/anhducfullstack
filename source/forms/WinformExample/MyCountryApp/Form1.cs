using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCountryApp.Repository;
using MyCountryApp.ViewModels;

namespace MyCountryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grdDistrict.AutoGenerateColumns = false;
           
        }
        
        private void SearchButton_Click(object sender, EventArgs e)
        {
            grdDistrict.DataSource = SearchDistrict(txtKeyword.Text, txtCity.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKeyword.Text = string.Empty;
            txtCity.Text = string.Empty;

            grdDistrict.DataSource = SearchDistrict(txtKeyword.Text, txtCity.Text);
        }

        private List<DistrictInformationViewModel> SearchDistrict(string keyword, string cityName)
        {
            var cityRepo = new CityRepository();
            var districtRepo = new DistrictRepository();

            var allCities = cityRepo.GetAll();
            var allDistricts = districtRepo.GetAll();

            var query = from d in allDistricts
                join c in allCities on d.CityCode equals c.Code
                select new DistrictInformationViewModel() { DistrictCode = d.Code, DistrictName = d.Name, CityName = c.Name };
            
            if (!string.IsNullOrEmpty(keyword))
            {
                keyword = keyword.ToLower();
                query = query.Where(x => x.DistrictName.ToLower().Contains(keyword) || x.DistrictCode.ToLower().Contains(keyword)).ToList();
            }
            if (!string.IsNullOrEmpty(cityName))
            {
                cityName = cityName.ToLower();
                query = query.Where(x => x.CityName.ToLower().Contains(cityName) ).ToList();
            }

            var result =  query.ToList();
            
            return result;
        }

       
    }
}
