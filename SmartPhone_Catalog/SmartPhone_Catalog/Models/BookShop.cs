using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookShop.Models
{
    [Serializable, XmlRoot("OnlineCosmeticsShop")]
    public class SmartphoneCatalog
    {
        [XmlArray("smartphone_specs")]
        public smartphone[] Smartphones;
        [XmlArray("smartphone_prices")]
        public smartphone_price[] Prices;
        [XmlArray("brands")]
        public brand[] Brand;
        [XmlArray("stores")]
        public store[] Stores;
    }
}
