using CategoryLibrary.Entities;
using ProductCatalog1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryLibrary
{
    public class CategoryMenu
    {
        public void showCategoryMenu()
        {
            Console.WriteLine("Enter Choice for Category");
            Console.WriteLine("\ta- Enter a Category");
            Console.WriteLine("\tb- List all Categories");
            Console.WriteLine("\tc- Delete a Category (Enter Short Code or ID to delete)");
            Console.WriteLine("\td- Search a Category (By Id, Name, Short Code)");
            string choice = Console.ReadLine();
            switch (choice.ToLower())
            {
                case "a":
                    Console.WriteLine("Enter Category Name");
                    string categoryName = Console.ReadLine();
                    Console.WriteLine("Enter Short Code");
                    string shortCode = Console.ReadLine();
                    Console.WriteLine("Enter Description");
                    string description = Console.ReadLine();
                    Category category = new Category { C_ID = Category.GeneratecategoryId(), Name = categoryName, ShortCode = shortCode, Description = description };
                    CFileoperation.fileWrite(category);
                    break;

                case "b":
                    CFileoperation.fileRead();
                    break;
                case "c":
                    break;
                case "d":
                    break;
                default:
                    Console.WriteLine("Please Enter Correct Choice");
                    break;
            }
        }
    }
}
