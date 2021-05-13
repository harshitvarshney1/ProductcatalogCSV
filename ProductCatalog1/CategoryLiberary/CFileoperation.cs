using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using CategoryLibrary.Entities;

namespace ProductCatalog1
{
    public class CFileoperation
    {
        public static void fileRead()
        {
            //string dirPath = @"C:/Users/s s infotech/source/repos/ProductCatalog1";
            string filePath = @"C:/Users/s s infotech/source/repos/ProductCatalog1/Category.csv";
            using (StreamReader input = File.OpenText(filePath))
            using (CsvHelper.CsvReader csvreader = new CsvHelper.CsvReader(input, System.Globalization.CultureInfo.CreateSpecificCulture("en-SI")))
            {
                IEnumerable<Category> category = csvreader.GetRecords<Category>();
                foreach (Category record in category)
                {
                    Console.WriteLine(record.C_ID);
                    Console.WriteLine(record.Name);
                    Console.WriteLine(record.ShortCode);
                    Console.WriteLine(record.Description);
                    
                }
            }
        }
        //public static void fileWrite(Category product)
        //{
        //    List<Category> data = new List<Category>();

        //    string filePath = @"C:/Users/s s infotech/source/repos/ProductCatalog1/Product.csv";
            
        //    data.Add(product);
            
        //    string filerow = "\n" + product.P_ID + "," + product.Name + "," + product.ShortCode + "," + product.Desciption + "," + product.Manufacturure + "," + product.ProductCategory + "," + product.sellingPrice;
        //    File.AppendAllText(filePath, filerow);
            
        //}
    }
}
