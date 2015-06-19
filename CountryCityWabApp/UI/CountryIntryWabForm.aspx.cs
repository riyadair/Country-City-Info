using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityWabApp.BLL;
using CountryCityWabApp.Model;

namespace CountryCityWabApp
{
    public partial class CountryIntryWabForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            countryGridView.DataSource = countryManager.GetAllCountries();
            countryGridView.DataBind();
        }
        CountryManager countryManager = new CountryManager();
        private Country aCountry;
        protected void saveButton_Click(object sender, EventArgs e)
        {
            aCountry = new Country();
            aCountry.Name = countryNameTextBox.Text;
            aCountry.About = countryAboutTextBox.Text;
            string message=countryManager.Save(aCountry);
            messageLabel.Text = message;
            ClearTextBox();
            countryGridView.DataSource = countryManager.GetAllCountries();
            countryGridView.DataBind();
        }

        public void ClearTextBox()
        {
            countryNameTextBox.Text = string.Empty;
            countryAboutTextBox.Text = string.Empty;
        }
    }
}