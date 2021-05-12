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
                    var categoryName = Console.ReadLine();
                    Console.WriteLine("Enter Short Code");
                    var shortCode = Console.ReadLine();
                    if (shortCode.Length <= 4)
                    {
                        Console.WriteLine("Enter Description");
                        var desc = Console.ReadLine();
                        // CategoryOperation.AddCategory(categoryName, shortCode, desc);
                    }
                    else
                    {
                        Console.WriteLine("Short Code should be less than or equal to 4");
                    }
                    break;
            }
        }
    }
}
