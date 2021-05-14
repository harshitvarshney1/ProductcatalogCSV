using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryLibrary.Entities
{
    public class Category
    {
        public static int cId;
        public int C_ID { get; set; }
        
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public string Description { get; set; }

        public Category()
        {
            cId = cId + 1;
        }
    }
}
