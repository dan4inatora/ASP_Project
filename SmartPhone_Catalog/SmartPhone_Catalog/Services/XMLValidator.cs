using Microsoft.AspNetCore.Http;
using System;
using System.Xml;

namespace BookShop.Models
{
    public class XMLValidator
    {
        
        public static bool isValidXML()
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;

            bool isValid;
            settings.Schemas.Add("",
                "C:\\Users\\Dan4inatora\\Desktop\\Kris_proj\\SmartPhone_Catalog\\SmartPhone_Catalog\\XML\\BookShopSchema.xsd");

            try
            {
                using (XmlReader reader =
                    XmlReader.Create(
                        "C:\\Users\\Dan4inatora\\Desktop\\Kris_proj\\SmartPhone_Catalog\\SmartPhone_Catalog\\XML\\Book_2.xml",
                        settings))
                {
                    while (reader.Read())
                    {
                        
                    }

                    isValid = true;
                }
            }
            catch (Exception e)
            {
                isValid = false;
            }

            return isValid;
        }

        public static bool isValidXML(string fileName)
        {
            
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;

            bool isValid;
            settings.Schemas.Add("",
                "C:\\Users\\Dan4inatora\\Desktop\\Kris_proj\\SmartPhone_Catalog\\SmartPhone_Catalog\\XML\\BookShopSchema.xsd");

            try
            {
                using (XmlReader reader = XmlReader.Create(
                    $"C:\\Users\\Dan4inatora\\Desktop\\Kris_proj\\SmartPhone_Catalog\\SmartPhone_Catalog\\XML\\{fileName}", settings))
                {
                    while (reader.Read())
                    {
                        
                    }

                    isValid = true;
                }
            }
            catch (Exception e)
            {
                isValid = false;
            }

            return isValid;
            
        }
    }
}