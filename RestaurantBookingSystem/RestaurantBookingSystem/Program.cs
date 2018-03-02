using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace RestaurantBookingSystem
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }

    class Table
    {

        int TableNumber { get; set; }

        int numberOfSeats;

        int NumberOfSeats
        { 
        get { return numberOfSeats; }
        set { numberOfSeats = value; }
        }

       // List<Table> tables = new List<Table>();

        public Table (int tableNumber, int numberOfSeats)
        {
            TableNumber = tableNumber;
            NumberOfSeats = numberOfSeats;

           // tables.Add(this);
        }

        public override string ToString()
        {
            return "Table Number = " + TableNumber + " and nomber of seats = " + NumberOfSeats;
        }
    }
}
