using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore
{
    public static class MainMenu
    {

        public static string DisplayMainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("---------\n");

            Console.WriteLine("1 - Add warehouse");

            // the next bit needs a query on number of warehouses to ensure > 0)
            {
                Console.WriteLine("2 - List/modify warehouses");
                Console.WriteLine("3 - Define item");
                Console.WriteLine("4 - amend price of item");
                Console.WriteLine("5 - Add item(s) to warehouse");
                Console.WriteLine("0 - Exit");
            }

            string userSelect = Console.ReadLine();
            return userSelect;

        } // end DisplayMenu


    } // endclass
}
