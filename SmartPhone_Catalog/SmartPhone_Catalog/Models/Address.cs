using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookShop.Models
{
    public class Address
    {
        [XmlElement("dimensions")]
        public string Dimensions;
        [XmlElement("weight")]
        public double Weight;
        [XmlElement("build")]
        public string Build;

        public Address()
        {
        }

        public Address(string dimensions, double weight, string build)
        {
            if (!String.IsNullOrEmpty(dimensions))
            {
                Dimensions = dimensions;
            }

            if (weight > 0 && weight < 1000)
            {
                Weight = weight;
            }

            if (!String.IsNullOrEmpty(build))
            {
                Build = build;
            }
        }
    }
}
