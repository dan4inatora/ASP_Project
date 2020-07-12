using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookShop.Models
{
    public class Order
    {
        [XmlAttribute("wlan")]
        public string Wlan;
        [XmlAttribute("bluetooth")]
        public string Bluetooth;
        [XmlAttribute("usb")]
        public string Usb;

        //public Miscellanious()
        //{

        //}

        //public Miscellanious(string wlan, string bluetooth, string usb)
        //{
        //    if (!String.IsNullOrEmpty(wlan))
        //    {
        //        Wlan = wlan;
        //    }

        //    if (!String.IsNullOrEmpty(bluetooth))
        //    {
        //        Bluetooth = bluetooth;
        //    }

        //    if (!String.IsNullOrEmpty(usb))
        //    {
        //        Usb = usb;
        //    }
        //}
    }
}
