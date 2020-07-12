using System;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Models
{
    public class DBManipulator : DbContext
    {
        public static int getRecordsCount(string tableName)
        {
            int rowsCount = 0;

            using (SqlConnection sqlConnection =
                new SqlConnection("Server=X1CARBON-KRIS;Database=Smartphone_Shop;Trusted_Connection=True"))
            {
                sqlConnection.Open();

                string queryString = $"SELECT count(*) FROM {tableName}";

                using (SqlCommand sqlCommand = new SqlCommand(queryString))
                {
                    sqlCommand.Connection = sqlConnection;
                    rowsCount = sqlCommand.ExecuteNonQuery();
                }
            }

            return rowsCount;
        }

        public static bool fillDatabase(SmartphoneCatalog smartphoneCatalog)
        {
            try
            {
                using (SqlConnection sqlConnection =
                    new SqlConnection("Server=X1CARBON-KRIS;Database=Smartphone_Shop;Trusted_Connection=True"))
                {
                    sqlConnection.Open();

                    foreach (var store in smartphoneCatalog.Stores)
                    {
                        using (SqlCommand sqlCommand = new SqlCommand(getQueryString(store)))
                        {
                            sqlCommand.Connection = sqlConnection;
                            sqlCommand.ExecuteNonQuery();
                        }
                    }

                    foreach (var brand in smartphoneCatalog.Brand)
                    {
                        using (SqlCommand sqlCommand = new SqlCommand(getQueryString(brand)))
                        {
                            sqlCommand.Connection = sqlConnection;
                            sqlCommand.ExecuteNonQuery();
                        }
                    }

                    foreach (var smartphone in smartphoneCatalog.Smartphones)
                    {
                        using (SqlCommand sqlCommand = new SqlCommand(getQueryString(smartphone)))
                        {
                            sqlCommand.Connection = sqlConnection;
                            sqlCommand.ExecuteNonQuery();
                        }
                    }

                    foreach (var price in smartphoneCatalog.Prices)
                    {
                        using (SqlCommand sqlCommand =
                            new SqlCommand(getQueryString(price)))
                        {
                            sqlCommand.Connection = sqlConnection;
                            sqlCommand.ExecuteNonQuery();
                        }
                    }

                    
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        private static string getQueryString(brand brand)
        {
            return $"INSERT INTO Brands(brand_id, brand_name) VALUES ('{brand.BrandId}', N'{brand.BrandName}')";
        }

        private static string getQueryString(smartphone smartphone)
        {
            return $"INSERT INTO Smartphone(smartphone_id, store_id, brand_id, model, dimensions, weight, build, display_type, display_size, " +
                $"display_resolution, camera_specs, camera_features, video_quality, battery, os, chipset, cpu, gpu, wlan, bluetooth, usb) " +
                   $"VALUES ('{smartphone.SmartphoneId}', '{smartphone.StoreId}', '{smartphone.BrandId}', N'{smartphone.Model}', N'{smartphone.Body.Dimensions}', N'{smartphone.Body.Weight}', N'{smartphone.Body.Build}', " +
                   $" N'{smartphone.Display.Type}', N'{smartphone.Display.Size}', N'{smartphone.Display.Resolution}', " +
                   $" N'{smartphone.Camera.Specs}', N'{smartphone.Camera.Features}', N'{smartphone.Camera.VideoQuality}', " +
                   $" N'{smartphone.Battery}', N'{smartphone.Platform.OS}', N'{smartphone.Platform.Chipset}', N'{smartphone.Platform.CPU}', " +
                   $" N'{smartphone.Platform.GPU}', '{smartphone.Miscellanious.Wlan}', '{smartphone.Miscellanious.Bluetooth}', '{smartphone.Miscellanious.Usb}')";
        }

        private static string getQueryString(smartphone_price price)
        {
            return $"INSERT INTO Prices(price_id, smartphone_id, currency, price) " +
                   $"VALUES('{price.PriceId}', '{price.SmartphoneID}', '{price.Currency}', N'{price.Smartphone_price}')";
        }

        private static string getQueryString(store store)
        {
            return $"INSERT INTO Shops(store_id, country, city, street, number) " +
                   $"VALUES('{store.StoreId}', N'{store.Country}', N'{store.City}' , N'{store.Street}', N'{store.Number}')";
        }
    }
}