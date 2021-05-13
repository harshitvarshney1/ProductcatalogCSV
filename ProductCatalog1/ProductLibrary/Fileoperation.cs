using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using ProductLibrary.Entities;
using CsvHelper.Configuration;
using System.Globalization;

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
                Console.WriteLine();
                Console.WriteLine("Id\t Name\t\t ShortCode\tDescription\t\tManufacturer\tCategory\tPrice");
                foreach (Product record in products)
                {
                    Console.WriteLine(record.P_ID + "\t" + record.Name + "\t\t" + record.ShortCode + "\t\t" + record.Desciption+ "\t\t\t" + record.Manufacturure+ "\t\t" + record.ProductCategory + "\t\t" + record.sellingPrice);
                    //Console.WriteLine(record.Name);
                    //Console.WriteLine(record.Manufacturure);
                    //Console.WriteLine(record.ProductCategory);
                    //Console.WriteLine(record.sellingPrice);
                    //Console.WriteLine(record.ShortCode);
                    //Console.WriteLine(record.Desciption);
                }
            }
        }
        public static void fileWrite(Product product)
        {
            List<Product> data = new List<Product>();
            string filePath = @"C:/Users/s s infotech/source/repos/ProductCatalog1/Product.csv";
            string lastLine = File.ReadLines(filePath).Last();           
            int s = lastLine[0] - '0';
            Console.WriteLine(Convert.ToInt32(s));
            Console.WriteLine(lastLine);
            //Product.pId = s;
            var config = new CsvConfiguration(CultureInfo.InvariantCulture);
            config.HasHeaderRecord = false;
            using (StreamWriter input = new StreamWriter(filePath, true))
            using (CsvHelper.CsvWriter csvwriter = new CsvHelper.CsvWriter(input, config))
            {
                data.Add(product);
                //csvwriter.WriteHeader<Product>();
                //string filerow = "\n" + product.P_ID + "," + product.Name + "," + product.ShortCode + "," + product.Desciption + "," + product.Manufacturure + "," + product.ProductCategory + "," + product.sellingPrice;
                //File.AppendAllText(filePath, filerow);
                //csvwriter.NextRecord();
                csvwriter.WriteRecords(data);
                input.Flush();
            }
        }
    }
}
