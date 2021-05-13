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

        public static void rowDelete(int id)
        {
            List<Category> records;
            string filePath = @"C:/Users/s s infotech/source/repos/ProductCatalog1/Category.csv";
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<Category>().ToList();
                for (int i = 0; i < records.Count; ++i)
                {
                    if (records[i].C_ID == id)
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
            string filePath = @"C:/Users/s s infotech/source/repos/ProductCatalog1/Category.csv";
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
