using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using CountryCityWabApp.Model;

namespace CountryCityWabApp.DAL
{
    public class CityGateway
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["CityInfoDBConnectionString"].ConnectionString;

        public int Save(City aCity)
        {
            string query = String.Format("INSERT INTO tbl_City VALUES('"+aCity.Name+"','"+aCity.About+"','"+aCity.Dwellers+"','"+aCity.Location+"','"+aCity.Weather+"','"+aCity.CountryInfo+"')");

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public bool IsCityNameAlreadyExist(City aCity)
        {
            string query = String.Format("SELECT * FROM tbl_City WHERE cityName='{0}'",aCity.Name);

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query,connection);
            bool isCityNameExist = false;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                isCityNameExist = true;
                break;
            }
            reader.Close();
            connection.Close();
            return isCityNameExist;
        }

        public DataTable GetAllCities()
        {
            string query = string.Format("SELECT cityName,dwellers,name FROM tbl_City JOIN tbl_Country ON tbl_City.country=tbl_Country.id");

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();

            adapter.Fill(data);
            connection.Close();

            return data;
        }

        public DataTable SearchByCityName(string cityName)
        {
            string query = string.Format("SELECT RANK() over(order by c.cityName asc) as Sl,* FROM tbl_City c JOIN tbl_Country t ON c.country=t.id WHERE c.cityName LIKE '%{0}%'",cityName);

            SqlConnection connection= new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter(query,connection);

            DataTable data = new DataTable();

            adapter.Fill(data);
            connection.Close();
            return data;
        }
    }
}