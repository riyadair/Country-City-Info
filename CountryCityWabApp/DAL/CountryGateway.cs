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
            return rowAffected;
        }
    }
}