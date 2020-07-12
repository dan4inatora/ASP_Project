using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookShop.Models
{
    public class brand
    {
        private static int Id;

        [XmlAttribute("brand_id")]
        public int BrandId;
        [XmlElement("brand_name")]
        public string BrandName;

        //public brand(string brandName)
        //{
        //    BrandId = Id;

        //    if (!String.IsNullOrEmpty(brandName))
        //    {
        //        BrandName = brandName;
        //    }
        //}
    }
}
