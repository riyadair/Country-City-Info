using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using CountryCityWabApp.DAL;
using CountryCityWabApp.Model;

namespace CountryCityWabApp.BLL
{
    public class CityManager
    {
        CityGateway cityGateway = new CityGateway();

        public string Save(City aCity)
        {
            string message = " ";
            if (aCity.Name == string.Empty)
            {
                message = "Please Fillup name box";
            }
            else if (aCity.About==string.Empty)
            {
                message = "Fillup Abot Box";
            }
            else if (aCity.Dwellers == 0)
            {
                message = "Dwellers Can't Zero";
            }
            else if(aCity.Location==string.Empty)
            {
                message = "Enter Location";
            }
            else if(cityGateway.IsCityNameAlreadyExist(aCity))
            {
                message = "City Name Already Exist";
            }
            else
            {
                message = "City Saved";
                cityGateway.Save(aCity);
            }
            return message;
        }

        public DataTable GetAllCities()
        {
            return cityGateway.GetAllCities();
        }

        public DataTable SearchByCityName(string cityName)
        {
            return cityGateway.SearchByCityName(cityName);
        }
    }
}