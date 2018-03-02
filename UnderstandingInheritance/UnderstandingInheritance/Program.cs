using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car() {
                Make = "BMW",
                Model = "model",
                Colour = "Black",
                Year = 2005 };

            printCarDetails(myCar);

            Console.ReadLine();
        }



        private static void printCarDetails(Car car)
        {
            Console.WriteLine("Here are the car's details: {0}", 
                car.FormatMe());
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        public string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Colour,
                this.Year);
        }
    }
}
