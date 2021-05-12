using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using ProductLibrary.Entities;

namespace ProductCatalog1
{
    public class Fileoperation
    {
        public static void fileRead()
        {
            //string dirPath = @"C:/Users/s s infotech/source/repos/ProductCatalog1";
            string filePath = @"C:/Users/s s infotech/source/repos/ProductCatalog1/Product.csv";
            using (StreamReader input = File.OpenText(filePath))
            using (CsvHelper.CsvReader csvreader = new CsvHelper.CsvReader(input, System.Globalization.CultureInfo.CreateSpecificCulture("en-SI")))
            {
                IEnumerable<Product> products = csvreader.GetRecords<Product>();
                foreach (Product record in products)
                {
                    Console.WriteLine(record.P_ID);
                    Console.WriteLine(record.Name);
                    Console.WriteLine(record.Manufacturure);
                    Console.WriteLine(record.ProductCategory);
                    Console.WriteLine(record.sellingPrice);
                    Console.WriteLine(record.ShortCode);
                    Console.WriteLine(record.Desciption);
                }
            }          
       }
        public static void fileWrite()
        {
            string filePath = @"C:/Users/s s infotech/source/repos/ProductCatalog1/Product.csv";
            string filerow = "\n" + "3" + "," + "Bat" + "," + "Bat" + "," + "Cricket Bat" + "," + "SS" + "," + "Sports" + "," + "2000";

            //if (!File.Exists(filePath))
            //{
            //    string fileHeader = "Id" + "," + "Name" + "," + "Price";
            //    File.WriteAllText(filePath, fileHeader);
            //    Console.WriteLine("heelo csv");
            //}
           File.AppendAllText(filePath, filerow);
        }


    }
}
