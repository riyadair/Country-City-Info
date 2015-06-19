using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityWabApp.BLL;
using CountryCityWabApp.Model;

namespace CountryCityWabApp.UI
{
    public partial class CityEntryWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            showGridView.DataSource = cityManager.GetAllCities();
            showGridView.DataBind();
        }
        CityManager cityManager = new CityManager();
        private City aCity;
        protected void saveButton_Click(object sender, EventArgs e)
        {
            aCity = new City();
            aCity.Name = nameTextBox.Text;
            aCity.About = aboutTextBox.Text;
            aCity.Dwellers = Convert.ToInt32(dwellersTextBox.Text);
            aCity.Location = locationTextBox.Text;
            aCity.Weather = weatherTextBox.Text;
            aCity.CountryInfo = Convert.ToInt32(countryDropDownList.SelectedItem.Value);

            lblMsg.Text = cityManager.Save(aCity);

            ClearTextboxes();

            showGridView.DataSource = cityManager.GetAllCities();
            showGridView.DataBind();
        }
        public void ClearTextboxes()
        {
            nameTextBox.Text = String.Empty;
            aboutTextBox.Text = String.Empty;
            dwellersTextBox.Text = String.Empty;
            locationTextBox.Text = String.Empty;
            weatherTextBox.Text = String.Empty;
        }
    }

}