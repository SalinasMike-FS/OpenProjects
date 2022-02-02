using System;
using System.Collections.Generic;
//Mike Salinas
//30 Jan 2021
//APA
//API project
namespace API
{
    public class Menu
    {
        private static List<string> _menuItems = new List<string>();

        public static string Title { get; private set; }

        public static List<string> Menuitems
        {
            get { return _menuItems; }
            set { _menuItems = value; }
        }

        public Menu()
        {
            Console.WriteLine("Menu created!");
            Console.Clear();

        }

        public void Init(string title, string itemsToBeAdded) //updates the title and cycles through the array and adds them to the list
        {
            Title = title;
            
                Menuitems.Add(itemsToBeAdded);
            
        }

        public void Display() //displays the menu items
        {
            Console.WriteLine("==================================");
            Console.WriteLine($"            {Title}");
            Console.WriteLine("==================================\r\n");
            int menuPosition = 1;
            foreach (string menuItem in Menuitems)
            {
                Console.WriteLine($"[{menuPosition}] {menuItem}");

                menuPosition++;
            }
        }
    }
}

