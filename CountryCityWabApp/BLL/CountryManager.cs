using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.Services.Description;
using CountryCityWabApp.DAL;
using CountryCityWabApp.Model;

namespace CountryCityWabApp.BLL
{
    public class CountryManager
    {
        CountryGateway countryGateway = new CountryGateway();

        public string Save(Country aCountry)
        {
            string message = " ";
            if (aCountry.Name == string.Empty || aCountry.About == string.Empty)
            {
                message = "Please Fill All Fields";
            }
            else if(countryGateway.IsCountryNameAlreadyExist(aCountry))
            {
                message = "Country name Already Exist";
            }
            else
            {
                message = "Data Saved";
                countryGateway.Save(aCountry);
            }
            return message;
        }

        public List<Country> GetAllCountries()
        {
            return countryGateway.GetAllCountries();
        }
    }
}