using System;



namespace RestaurantTest
{
    public class RestaurantTest
    {
        public static void Main()
        {
            Restaurant obj = new Restaurant("MyGaff", "123 High St", 0.15);

            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Address);
            Console.WriteLine(obj.GratuityRate);
            Console.WriteLine("------------------------");

            obj.GenerateSalesReceipt();

        }

    }

    public class Restaurant
    {
        // instance variables
        string name, address;
        double gratuityRate;

        // properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        } // end property

        public string Address
        {
            get { return address; }
            set { address = value; }
        } // end property

        public double GratuityRate
        {
            get { return gratuityRate; }
            set
            {
                if (value >= 0)
                {
                    gratuityRate = value;
                }
            }
        }  // end property

        // end properties

        // constructor
        public Restaurant(string name, string address, double gratuityRate)
        {
            Name = name;
            Address = address;
            GratuityRate = gratuityRate;
        } // end constructor

        public void GenerateSalesReceipt() //start method
        {
            double price = 0;
            double grandTotal = 0;
            double subTotal = 0;
            double gratuityAmount = 0;
            int groupSize;



            while (price != -1)
            {
                subTotal += price;
                Console.Write("Enter price of food item [-1 to quit]: ");
                price = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("-----------------------------");
            Console.Write("how many people in your party? ");
            groupSize = Convert.ToInt32(Console.ReadLine());


            if (groupSize < 6)
            { gratuityRate = 0; }


            gratuityAmount = gratuityRate * subTotal;
            grandTotal = subTotal + gratuityAmount;


            Console.WriteLine("-----------------------------");
            Console.WriteLine("Subtotal = {0:C}", subTotal);
            Console.WriteLine("{0:P} Gratuity: {1:C}", gratuityRate, gratuityAmount);
            Console.WriteLine("Total: {0:C}", grandTotal);


        } // end method
    }
}

