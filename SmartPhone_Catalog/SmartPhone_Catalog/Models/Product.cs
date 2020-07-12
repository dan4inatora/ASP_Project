using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookShop.Models
{
    public class Product
    {
        [XmlElement("os")]
        public string OS;
        [XmlElement("chipset")]
        public string Chipset;
        [XmlElement("cpu")]
        public string CPU;
        [XmlElement("gpu")]
        public string GPU;

        public Product()
        {
        }

        public Product(string os, string chipset, string cpu, string gpu)
        {
            if (!String.IsNullOrEmpty(os))
            {
                OS = os;
            }

            if (!String.IsNullOrEmpty(chipset))
            {
                Chipset = chipset;
            }

            if (!String.IsNullOrEmpty(cpu))
            {
                CPU = cpu;
            }

            if (!String.IsNullOrEmpty(gpu))
            {
                GPU = gpu;
            }
        }
    }
}
