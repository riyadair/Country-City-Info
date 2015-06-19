using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryCityWabApp.Model;

namespace CountryCityWabApp.DAL
{
    public class CountryGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["cityInfoConString"].ConnectionString;

        public int Save(Country aCountry)
        {
            string query = "INSERT INTO tbl_Country VALUES('"+aCountry.Name+"','"+aCountry.About+"')";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public bool IsCountryNameAlreadyExist(Country aCountry)
        {
            string query = String.Format("SELECT * FROM tbl_Country WHERE name='{0}'",aCountry.Name);
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            bool isCountryNameExist = false;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                isCountryNameExist = true;
                break;
            }
            reader.Close();
            connection.Close();
            return isCountryNameExist;
        }

        public List<Country> GetAllCountries()
        {
            string query = "SELECT * FROM tbl_Country";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            List<Country> countries = new List<Country>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                i++;
                Country aCountry = new Country();
                aCountry.Id = i;
                aCountry.Name = reader["name"].ToString();
                aCountry.About = reader["about"].ToString();

                countries.Add(aCountry);
            }
            reader.Close();
            connection.Close();
            return countries;
        }
    }
}