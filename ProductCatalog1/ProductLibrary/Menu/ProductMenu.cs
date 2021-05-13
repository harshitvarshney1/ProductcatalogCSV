using ProductCatalog1;
using ProductLibrary.Entities;
using System;
using System.Collections.Generic;
using System.IO;
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
            Console.WriteLine("\tc- Delete a Product (ID to delete)");
            Console.WriteLine("\td- Search a Product (By Name)");
            string choice = Console.ReadLine();
            switch (choice.ToLower())
            {
                case "a":
                    string filePath = @"C:/Users/s s infotech/source/repos/ProductCatalog1/Product.csv";
                    string lastLine = File.ReadLines(filePath).Last();
                    int lastrowid = lastLine[0] - '0';
                    Product.pId = lastrowid;
                    Console.WriteLine("Enter Product Name");
                    string  productName = Console.ReadLine();
                    Console.WriteLine("Enter Short Code");
                    string shortCode = Console.ReadLine();
                    Console.WriteLine("Enter Description");
                    string description = Console.ReadLine();
                    Console.WriteLine("Enter Manufacturer");
                    string manufacturer = Console.ReadLine();
                    Console.WriteLine("Enter Product Category");
                    string pcategory = Console.ReadLine();
                    Console.WriteLine("Enter Price");
                    int  price = Convert.ToInt32(Console.ReadLine());
                    Product product = new Product { P_ID = Product.pId, Name = productName, ShortCode = shortCode, Desciption = description, Manufacturure = manufacturer, ProductCategory = pcategory, sellingPrice = price};
                    Fileoperation.fileWrite(product);
                    break;
                   
                case "b":
                    Fileoperation.fileRead();
                    break;
                case "c":
                    Console.WriteLine("Enter Id to delete");
                    int delete = Convert.ToInt32(Console.ReadLine());
                    Fileoperation.rowDelete(delete);
                    break;
                case "d":
                    Console.WriteLine("Enter Name to search");
                    string search = Console.ReadLine();
                    Fileoperation.rowSearch(search);
                    break;
                default:
                    break;
            }
        }
    }
}
