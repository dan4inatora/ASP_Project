using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookShop.Models
{
    public class store
    {
        private static int Id;

        [XmlAttribute("store_id")]
        public int StoreId;
        [XmlElement("country")]
        public string Country;
        [XmlElement("city")]
        public string City;
        [XmlElement("street")]
        public string Street;
        [XmlElement("number")]
        public int Number;

        //public store(string country, string city, string street, int number)
        //{
        //    StoreId = Id;

        //    if (!String.IsNullOrEmpty(country))
        //    {
        //        Country = country;
        //    }

        //    if (!String.IsNullOrEmpty(city))
        //    {
        //        City = city;
        //    }

        //    if (!String.IsNullOrEmpty(street))
        //    {
        //        Street = street;
        //    }

        //    if (number > 0 && number < 300)
        //    {
        //        Number = number;
        //    }
        //}
    }
}
