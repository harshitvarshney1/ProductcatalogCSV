using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using CategoryLibrary.Entities;
using CsvHelper.Configuration;
using System.Globalization;

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
                Console.WriteLine();
                Console.WriteLine("Id\t Name\t\t ShortCode\tDescription");
                foreach (Category record in category)
                {
                    Console.WriteLine(record.C_ID+ "\t" + record.Name + "\t\t" + record.ShortCode+ "\t" + record.Description);                
                }
            }
        }
        public static void fileWrite(Category category)
        {
            List<Category> cdata = new List<Category>();
            string filePath = @"C:/Users/s s infotech/source/repos/ProductCatalog1/Category.csv";
            //string lastLine = File.ReadLines(filePath).Last();
            //int s = lastLine[0] - '0';
            //Console.WriteLine(Convert.ToInt32(s));
            //Console.WriteLine(lastLine);
            
            var config = new CsvConfiguration(CultureInfo.InvariantCulture);
            config.HasHeaderRecord = false;
            using (StreamWriter input = new StreamWriter(filePath, true))
            using (CsvHelper.CsvWriter csvwriter = new CsvHelper.CsvWriter(input, config))
            {
                cdata.Add(category);
                csvwriter.WriteRecords(cdata);
                input.Flush();
            }
        }
    }
}
