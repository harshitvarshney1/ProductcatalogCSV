using CategoryLibrary.Entities;
using ProductCatalog1;
using System;
using System.Collections.Generic;
using System.IO;
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
                    string filePath = @"C:/Users/s s infotech/source/repos/ProductCatalog1/Category.csv";
                    string lastLine = File.ReadLines(filePath).Last();
                    int lastrowid = lastLine[0] - '0';
                    Category.cId = lastrowid;
                    Console.WriteLine("Enter Category Name");
                    string categoryName = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(categoryName) || int.TryParse(categoryName, out _))
                    {
                        Console.WriteLine("Category Name is Mandatory");
                        categoryName = Console.ReadLine();
                    }
                    Console.WriteLine("Enter Short Code");
                    string shortCode = Console.ReadLine();
                    while (shortCode.Length > 5 || string.IsNullOrWhiteSpace(shortCode))
                    {
                        Console.WriteLine("ShortCode id mandatory and should be less than 5");
                        shortCode = Console.ReadLine();
                    }
                    Console.WriteLine("Enter Description");
                    string description = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(description) || int.TryParse(description, out _))
                    {
                        Console.WriteLine("Category Name is Mandatory");
                        description = Console.ReadLine();
                    }
                    Category category = new Category { C_ID = Category.cId, Name = categoryName, ShortCode = shortCode, Description = description };
                    CFileoperation.fileWrite(category);
                    break;

                case "b":
                    CFileoperation.fileRead();
                    break;
                case "c":
                    Console.WriteLine("Enter Id to delete");
                    int delete = Convert.ToInt32(Console.ReadLine());
                    CFileoperation.rowDelete(delete);
                    break;
                case "d":
                    Console.WriteLine("Enter Name to search");
                    string search = Console.ReadLine();
                    CFileoperation.rowSearch(search);
                    break;
                default:
                    Console.WriteLine("Please Enter Correct Choice");
                    break;
            }
        }
    }
}
