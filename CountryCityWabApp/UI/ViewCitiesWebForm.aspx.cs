using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityWabApp.BLL;

namespace CountryCityWabApp.UI
{
    public partial class ViewCitiesWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        CityManager cityManager = new CityManager();
        protected void searchButton_Click(object sender, EventArgs e)
        {
            string city = cityNameTextBox.Text;

            string countey = countryDropDownList.SelectedItem.ToString();
            //string countey = countryDropDownList.Text;
            if (cityNameRadiobox.Checked)
            {
                showGridView.DataSource =cityManager.SearchByCityName(city);
                showGridView.DataBind();
            }
            else if(countryNameRadiobox.Checked)
            {
                showGridView.DataSource ="";
                showGridView.DataBind();
            }
            else
            {
                
            }
        }
    }
}