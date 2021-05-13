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
                }
            }
        }
        public static void fileWrite(Product product)
        {
            List<Product> data = new List<Product>();
            string filePath = @"C:/Users/s s infotech/source/repos/ProductCatalog1/Product.csv";
            //string lastLine = File.ReadLines(filePath).Last();           
            //int s = lastLine[0] - '0';
            //Console.WriteLine(Convert.ToInt32(s));
            //Console.WriteLine(lastLine);
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

        public static void rowDelete(int id)
        {
            List<Product> records;
            string filePath = @"C:/Users/s s infotech/source/repos/ProductCatalog1/Product.csv";
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<Product>().ToList();
                for (int i = 0; i < records.Count; ++i)
                {
                    if (records[i].P_ID == id)
                    {
                        records.RemoveAt(i);
                    }
                }
            }
            using (var writer = new StreamWriter(filePath))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(records);
            }
        }

        public static void rowSearch(string name)
        {
            string filePath = @"C:/Users/s s infotech/source/repos/ProductCatalog1/Product.csv";
            var strLines = File.ReadLines(filePath);
            foreach (var line in strLines)
            {

                if (line.Split(',')[1].Equals(name))
                {
                    Console.WriteLine(line);
                    return;
                }

            }
        }
    }
}
