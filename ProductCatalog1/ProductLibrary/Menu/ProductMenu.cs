using ProductCatalog1;
using ProductLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProductLibrary
{
    public class ProductMenu
    {
        public void showProductMenu()
        {
            Console.WriteLine("Enter Choice for Product");
            Console.WriteLine("\ta- Enter a Product");
            Console.WriteLine("\tb- List all Products");
            Console.WriteLine("\tc- Delete a Product (Enter Short Code or ID to delete)");
            Console.WriteLine("\td- Search a Product (By Id, Name, Short Code, Selling Price Greater than/Less Than/Equal To entered price)");
            string choice = Console.ReadLine();
            switch (choice.ToLower())
            {
                case "a":
                    
                    Console.WriteLine("Enter Product Name");
                    string  productName = Console.ReadLine();
                    Console.WriteLine("Enter Short Code");
                    string shortCode = Console.ReadLine();
                    Console.WriteLine("Enter Description");
                    string description = Console.ReadLine();
                    Console.WriteLine("Enter Amnufacturer");
                    string manufacturer = Console.ReadLine();
                    Console.WriteLine("Enter Product Category");
                    string pcategory = Console.ReadLine();
                    Console.WriteLine("Enter Price");
                    int  price = Convert.ToInt32(Console.ReadLine());
                    Product product = new Product { P_ID = Product.GenerateProductId(), Name = productName, ShortCode = shortCode, Desciption = description, Manufacturure = manufacturer, ProductCategory = pcategory, sellingPrice = price};

                    Fileoperation.fileWrite(product);
                    break;
                   
                case "b":
                    Fileoperation.fileRead();
                    break;
                case "c":
                    break;
                case "d":
                    break;
                default:
                    break;
            }
        }
    }
}
