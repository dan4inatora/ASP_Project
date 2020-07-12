using System;
using System.Xml.Serialization;


namespace BookShop.Models
{
    public class smartphone
    {
        private static int Id;

        [XmlElement("model")]
        public string Model;
        [XmlAttribute("smartphone_id")]
        public int SmartphoneId;
        [XmlAttribute("store_id")]
        public int StoreId;
        [XmlAttribute("brand_id")]
        public int BrandId;
        [XmlElement("body")]
        public Address Body;
        [XmlElement("display")]
        public Display Display;
        [XmlElement("camera")]
        public Contact Camera;
        [XmlElement("battery")]
        public string Battery;
        [XmlElement("platform")]
        public Product Platform;
        [XmlElement("miscelanious")]
        public Order Miscellanious;

        //public smartphone()
        //{

        //}
        //public smartphone(string model, Body body, Display display, Camera camera, string battery, Platform platform, Miscellanious miscellanious)
        //{
        //    Body = body;
        //    Display = display;
        //    Camera = camera;

        //    if(!String.IsNullOrEmpty(model))
        //    {
        //        Model = model;
        //    }

        //    if (!String.IsNullOrEmpty(battery))
        //    {
        //        Battery = battery;
        //    }

        //    Platform = platform;
        //    Miscellanious = miscellanious;
        //}
    }
}
