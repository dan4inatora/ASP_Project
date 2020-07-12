using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookShop.Models
{
    public class smartphone_price
    {
        private static int Id;

        [XmlAttribute("price_id")]
        public int PriceId;
        [XmlAttribute("smartphone_id")]
        public int SmartphoneID;
        [XmlAttribute("currency")]
        public string Currency;
        [XmlElement("price")]
        public float Smartphone_price;

        //public smartphone_price(string currency, float price)
        //{
        //    PriceId = Id;

        //    if (!String.IsNullOrEmpty(currency))
        //    {
        //        Currency = currency;
        //    }

        //    if(price >= 0 && price <= 10000)
        //    {
        //        Smartphone_price = price;
        //    }
        //}
    }
}
