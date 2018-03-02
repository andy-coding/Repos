using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp2
{

    struct Account
    {
        enum status
        {
            Active,
            Frozen,
            Closed
        };

        enum type
        {
            Standard,
            HighInterest
        };

        private string accName;
        private decimal accBalance;
        private status accStatus;
        private type accType;
        private decimal accInterestRate;


        public static void CreateArray()
        {
            Account[] Accounts = new Account[100];
        }

        


        public static bool AccDeposit()
        {
            Console.Write("How much do you wish to deposit?");
            Console.ReadLine();
            Console.Clear();
            return true;
        }

        public static bool AccWithdrawFunds()
        {
            Console.Write("How much do you wish to withdraw?");
            Console.ReadLine();
            Console.Clear();
            return true;
        }
    }



    class Menu //  displays the main menu
    {
        public static int menu() // this displays the main menu
        {

            Account.CreateArray();

            int menuSwitch = 0;

            do { 
            
                Console.WriteLine("Banking Main Menu");
                Console.WriteLine("-----------------\n");
                Console.WriteLine("Choose from the following options:\n");
                Console.WriteLine("1 - create account");
                Console.WriteLine("2 - deposit funds");
                Console.WriteLine("3 - withdraw funds");
                Console.WriteLine("4 - get balance");
                Console.WriteLine("5 - get overdraft limit");
                Console.WriteLine("6 - change contact details");
                Console.WriteLine("7 - close account");
                Console.WriteLine("8 - End program\n");

           

                menuSwitch = CheckInputs.CheckInt("Enter menu option", 0, 8);

                switch (menuSwitch)
                {
                    case 1:
                        Account.AccCreate();
                        break;
                    case 2:
                        Account.AccDeposit();
                        break;
                    case 3:
                        Account.AccWithdrawFunds();
                        break;
                    case 8:
                        break;
                    default:
                        Console.Write("Invalid entry");
                        break;
                }
            }
            while (menuSwitch != 8);

            return menuSwitch;

        }
    }


    class CheckInputs  // Checks inputs for acceptable responses
    {
        public static int CheckInt(string prompt, int MinInt, int MaxInt)
        {

            int intResult = 0;
            do
            {
                try
                {
                    Console.WriteLine(prompt);
                    string intString = Console.ReadLine();
                    intResult = int.Parse(intString);
                }
                catch
                {
                    Console.WriteLine("Invalid entry");
                }
            }
            while ((intResult < MinInt) || (intResult > MaxInt));

            return intResult;
        }

        public static decimal CheckDecimal(string prompt, decimal MinDec, decimal MaxDec)
        {

            int decResult = 0;
            do
            {
                try
                {
                    Console.WriteLine(prompt);
                    string intDecimal = Console.ReadLine();
                    decResult = int.Parse(intDecimal);
                }
                catch
                {
                    Console.WriteLine("Invalid entry");
                }
            }
            while ((decResult < MinDec) || (decResult > MaxDec));

            return decResult;
        }


        public static string CheckString(string prompt)
        {
            string result = "";

            do
            {
                try
                {
                    Console.WriteLine(prompt);
                    result = Console.ReadLine();
                }
                catch
                {

                }
            } while (result == "");
            return result;
        }
    }


    class Program
    {

        public static int AccArrayNumber = 1;

        private Account[] Accounts = new Account[100];

        public static void Main()
        {

        int menuOption = Menu.menu();


            //    Console.WriteLine(menuOption + "Chosen");
            // Console.ReadLine();

        }



    }
}


