using CategoryLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductCatalog1;
namespace ProductLibrary.Entities
{
    public class Product 
    {        
        public static int pId;
        public int P_ID { get; set; }
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public string Desciption { get; set; }
        public string Manufacturure { get; set; }      
        public string ProductCategory { get; set; }
        public int sellingPrice { get; set; }
        public Product()
        {
            pId = pId + 1;
        }
    }
}
