using System;

namespace ProductCatalog1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Fileoperation.fileWrite();
            Menu menu = new Menu();
            menu.createMenu();
            Fileoperation.fileRead();
        }
    }
}
