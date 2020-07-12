using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookShop.Models
{
    public class Display
    {
        [XmlElement("type")]
        public string Type;
        [XmlElement("size")]
        public string Size;
        [XmlElement("resolution")]
        public string Resolution;

        public Display()
        {

        }

        public Display(string type, string size, string resolution)
        {
            if (!String.IsNullOrEmpty(type))
            {
                Type = type;
            }

            if (!String.IsNullOrEmpty(size))
            {
                Size = size;
            }

            if (!String.IsNullOrEmpty(resolution))
            {
                Resolution = resolution;
            }
        }
    }
}
