using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityWabApp.Model
{
    public class City
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public string About { get; set; }
        public double Dwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public int CountryInfo { get; set; }
    }
}