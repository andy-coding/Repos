using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore
{
    public class Program
    {

        public static void Main()
        {

            List<Warehouse> Warehouses = new List<Warehouse>();
            List<Item> Items = new List<Item>();
            List<Stock> stockitems = new List<Stock>();

            int userInput = 0;

            r = 2;
            do
            {
                userInput = Int32.Parse(MainMenu.DisplayMainMenu());

                switch (userInput)
                {

                    case 1:
                        {
                            Console.Write("Name of new warehouse (or 0 to return to main menu): ");
                            string inputString = Console.ReadLine();
                            if (inputString == "0")
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                try
                                {
                                    var newWarehouse = new Warehouse(inputString);
                                    Console.WriteLine("Warehouse: {0} created.", newWarehouse.Name);
                                    Warehouses.Add(newWarehouse);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex);
                                }
                                break;
                            }
                        }

                    case 2:
                        {
                            foreach (var item in Warehouses)
                            {
                                Console.WriteLine("Warehouse name: {0}", item.Name);
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.Write("name of item: ");
                            string itemName = Console.ReadLine();
                            Console.Write("price of item: ");
                            decimal itemPrice = decimal.Parse(Console.ReadLine());

                            var newItem = new Item(itemName, itemPrice);
                            Items.Add(newItem);

                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Which item do you wish to change?");
                            Console.WriteLine("itemnumber   item    ");
                            Console.WriteLine("------------------------");

                            foreach (var item in Items)
                            {
                                Console.WriteLine("{0}           {1}", Items.IndexOf(item), item.Name);
                            }

                            int itemSelect = Int32.Parse(Console.ReadLine());

                            Console.WriteLine("Current price of {0}: {1}", Items[itemSelect].Name, Items[itemSelect].Price);
                            Console.WriteLine("new price: ");

                            var newPrice = decimal.Parse(Console.ReadLine()); 
                            
                            Items[itemSelect].UpdatePrice(newPrice);

                            break;
                        }
                    case 5:
                        {


                            for (int i = 0; i < stockitems.Count; i++)
                            {
                                Console.WriteLine("Item: {0,20} Warehouse {1}", Items[i], Warehouses[i]);
                            }
                           
                            Console.WriteLine("Enter item name");
                            string inputItem = Console.ReadLine();
                            Console.WriteLine("Enter warehouse name");
                            string inputWarehouseName = Console.ReadLine();

                            Warehouse x=null;
                            for (int i = 0; i < Warehouses.Count; i++)
                            {
                                if (Warehouses[i].Name == inputWarehouseName)
                                {
                                    x = Warehouses[i];
                                }
                            }

                            Item y=null;
                            for (int i = 0; i < Items.Count; i++)
                            {
                                if (Items[i].Name == inputItem)
                                {
                                    y = Items[i];
                                }
                            }

                            Console.WriteLine(x.ToString());
                           
                            var stockItem = new Stock(x,y);
                            break;
                        }
                    default:
                        {
                            break;
                        }

                }

            } while (userInput != 0);

        }

    }   
}
