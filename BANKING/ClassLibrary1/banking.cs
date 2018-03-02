using System;

namespace interfacetest

{

    public interface IAccount // interface for all accounts
    {
        decimal GetBalance();
        bool WithdrawFunds(decimal inmethod2);
        void AddFunds(decimal inmethod3);
        bool CreateAcc();
    }

    public class StandardAccount : IAccount   // main class definition of account
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


        public bool CreateAcc()
        {
            Console.Clear();
            Console.WriteLine("Enter account name: ");
            try
            {
                accName = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("try again");
            }
            Console.WriteLine("Enter opening balance: ");
            try
            {
            //    accBalance = InputDecimal(Console.ReadLine());

            }
            catch
            {

            }


            return false;
        }


        public decimal GetBalance()
        {
            return accBalance;
        }
        public virtual bool WithdrawFunds(decimal inmethod2)
        {
            return true;
        }
        public void AddFunds(decimal inFunds)
        {
            try
            {
                accBalance = accBalance + inFunds;
            }
            catch
            {
                Console.WriteLine("Funds could not be added.");
            }
    
        }

    }

    public class BabyAccount : StandardAccount,IAccount // as per standard account but different WithdrawFunds method
    {

        
        public override bool WithdrawFunds(decimal inmethod2)
        {
            return true;
        }

    }


    class Menu //  displays the main menu
    {
        public static int menu() // this displays the main menu
        {



            int menuSwitch = 0;

            do
            {

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



             //   menuSwitch = CheckInputs.CheckInt("Enter menu option", 0, 8);

                switch (menuSwitch)
                {
                    case 1:
                        //Account.AccCreate();
                        break;
                    case 2:
                       // Account.AccDeposit();
                        break;
                    case 3:
                      //  Account.AccWithdrawFunds();
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


    public class Input
    {
        decimal returnDec;

        public decimal InputDecimal(string inputChar)
        {
            try
            {
                returnDec = decimal.Parse(inputChar);
            }
            catch
            {
                Console.WriteLine("Invalid amount - please try again or press x to return to previous menu");
            }
            return returnDec;
        }



    }

    public class Banking
    {
        public static void Main()
        {

            int accountstot = 0;

            StandardAccount [] Accounts = new StandardAccount[100];
            Accounts[0] = new StandardAccount();

            // Menu.menu();

            Console.WriteLine("sdfsdfsd");
            string gdg=Console.ReadLine();
            



        }
    }
}
