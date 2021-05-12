using CategoryLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary.Entities
{
    public class Product : Category
    {
        public static int pId = 1;
        public int P_ID { get; set; }
        public static int GenerateProductId()
        {
            return pId++;
        }

        public string Manufacturure { get; set; }      
        public string ProductCategory { get; set; }
        public int sellingPrice { get; set; }
    }
}
