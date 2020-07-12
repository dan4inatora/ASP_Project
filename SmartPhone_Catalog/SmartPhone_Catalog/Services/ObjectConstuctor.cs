using System;
using System.Globalization;
using Microsoft.AspNetCore.Http;

namespace BookShop.Models
{
    public class ObjectConstuctor
    {
        public static BookShop constructXMLObject(IFormCollection formData)
        {
            BookShop smartphoneCatalog = new BookShop();

            //smartphoneCatalog.Smartphones = new smartphone[1];
            //smartphoneCatalog.Prices = new smartphone_price[1];
            //smartphoneCatalog.Stores = new store[1];
            //smartphoneCatalog.Brand = new brand[1];
            //store store = new store(formData["country"], formData["city"],
            //    formData["street"], Int16.Parse(formData["number"]));

            //brand brand = new brand(formData["brand_name"]);

            //smartphone_price price = new smartphone_price(formData["currency"], float.Parse(formData["price"]));

            //Body body = new Body(formData["dimensions"], Double.Parse(formData["weight"]), formData["build"]);

            //Display display = new Display(formData["type"], formData["size"], formData["resolution"]);

            //Camera camera = new Camera(formData["specs"], formData["features"], formData["video_quality"]);

            //Platform platform = new Platform(formData["os"], formData["chipset"], formData["cpu"], formData["gpu"]);

            //Miscellanious miscellanious = new Miscellanious(formData["wlan"], formData["bluetooth"], formData["usb"]);

            //smartphone smartphone = new smartphone(formData["model"], body, display, camera, formData["battery"], platform, miscellanious);

            //smartphoneCatalog.Smartphones[0] = smartphone;
            //smartphoneCatalog.Brand[0] = brand;
            //smartphoneCatalog.Prices[0] = price;
            //smartphoneCatalog.Stores[0] = store;

            return smartphoneCatalog;
        }
    }
}