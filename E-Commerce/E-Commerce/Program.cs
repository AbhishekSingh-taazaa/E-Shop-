
using E_Commerce.Authentication;
using System;

namespace E_Commerce
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MainMenu mainMenu = new MainMenu();
            mainMenu.Menu();
        }
    }
}
