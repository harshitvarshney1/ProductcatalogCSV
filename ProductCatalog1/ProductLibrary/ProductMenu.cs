using ProductCatalog1;
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
                    var productName = Console.ReadLine();

                    Console.WriteLine("Enter Short Code");
                    var shortCode = Console.ReadLine();
                    if (shortCode.Length <= 4)
                    {
                        Console.WriteLine("Enter Description");
                        var desc = Console.ReadLine();
                        Console.WriteLine("Enter Price");
                        int price = Convert.ToInt32(Console.ReadLine());
                        if (price > 0)
                        {
                            Console.WriteLine("Enter Product Manufacturer Name");
                            var manufactureName = Console.ReadLine();
                            //ProductOperation.AddProduct(productName, shortCode, desc, price, manufactureName);
                        }
                        else
                        {
                            Console.WriteLine("Price Should be greater than zero!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Short Code should be less than or equal to 4");
                    }
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
