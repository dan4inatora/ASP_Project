using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using BookShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Serialize()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Models.BookShop));

            var filesInfo = new Dictionary<string, bool>();

            for (int index = 1; index <= 20; index++)
            {
                try
                {
                    string fileName = $"Book_{index}.xml";
                    bool validXML = XMLValidator.isValidXML(fileName);
                    string path = Environment.CurrentDirectory;

                    FileStream fileStream = new FileStream(
                        $"C:\\Users\\Dan4inatora\\Desktop\\Kris_proj\\SmartPhone_Catalog\\SmartPhone_Catalog\\XML\\Book_{index}.xml",
                        FileMode.Open);

                    if (validXML)
                    {
                        Models.BookShop smartphoneCatalog =
                            (Models.BookShop) xmlSerializer.Deserialize(fileStream);
                        var success = DBManipulator.fillDatabase(smartphoneCatalog);
                        ViewBag.Sucess = success;
                    }

                    fileStream.Close();
                    filesInfo.Add(fileName, validXML);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    ViewBag.IncorrectFormat = true;
                }
            }

            ViewBag.FilesInfo = filesInfo;

            return View();
        }
    }
}