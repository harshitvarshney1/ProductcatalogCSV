using CategoryLibrary;
using ProductLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog1
{
    public class Menu
    {
        public void createMenu()
        {
            while (true)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine(" 1- Product\n 2- Category\n 3- Exit the App!");
                string userchoice = Console.ReadLine();
                switch(userchoice)
                {
                    case "1":
                        ProductMenu pmenu = new ProductMenu();
                        pmenu.showProductMenu();
                        break;
                    case "2":
                        CategoryMenu cmenu = new CategoryMenu();
                        cmenu.showCategoryMenu();
                        break;
                    case "3":
                        Console.WriteLine("You have disconnected from program");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Please Enter correct choice");
                        break;

                }
            }
        }
    }
}
