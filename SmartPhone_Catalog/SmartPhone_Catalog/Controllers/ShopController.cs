using System;
using System.IO;
using System.Xml.Serialization;
using BookShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save()
        {
            var formData = this.Request.Form;

            try
            {
                Models.BookShop onlineCosmeticShop = ObjectConstuctor.constructXMLObject(formData);

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Models.BookShop));
                FileStream fileStream = new FileStream(
                    $"C:\\Users\\Dan4inatora\\Desktop\\Kris_proj\\SmartPhone_Catalog\\SmartPhone_Catalog\\XML\\G_Books.xml",
                    FileMode.CreateNew);

                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    xmlSerializer.Serialize(streamWriter, onlineCosmeticShop);
                }

                string name = "G_Books.xml";
                bool isValidXML = XMLValidator.isValidXML(name);

                if (isValidXML)
                {
                    DBManipulator.fillDatabase(onlineCosmeticShop);
                }

                ViewBag.ValidXML = isValidXML;
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
                ViewBag.FileExists = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                ViewBag.IncorrectFormat = true;
            }

            return View("Save");
        }
    }
}