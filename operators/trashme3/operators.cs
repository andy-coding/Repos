using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    class operators
    {


        static void PrimeNumbers() 
        {
            int range; 

            Console.Write("Enter a value up to which prime numbers will be calculated: ");


             int inputInt()
                {
                int range2;

                bool parseSuccess = false;

                while (parseSuccess == false)
                {
                    
                    string inChar = Console.ReadLine();
                    parseSuccess = Int32.TryParse(inChar, out range2);
                    Console.Write(parseSuccess ? "Value accepted." + range2 : "Invalid number.");
                }

                return range2;
            }

            inputInt();


            bool isPrime;


            for (int i = 3; i <= range; i++)
            {
                isPrime = true; //  it's a prime number unless we cna prove it's not.

                for (int j = 2; j < i; j++) // inner loop between 2 and i-1 (avoids testing for divisible by 1 or by itself)
                {
                   int imodj = (i % j);

                   if (imodj == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("{0} is a prime number.", i);
                }
            }

        }



        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;
            int neg = -1;


            Console.WriteLine(a > b ? "a > b" : "a <= b");

            int[] array1 = { 1, 2, 3 };
            Console.WriteLine("array values: element 0:{0}\telement 1:{1}\telement 2:{2}", array1[0], array1[1], array1[2]);

            float c = (float)a / (float)b;

            Console.WriteLine("int a/b = " + c);

            Console.WriteLine("absolute value of neg -1 = " + Math.Max(a, b));

            double d = (double)1 / 2;
            Console.WriteLine("d = 1/2 = " + d);


            /*  string radiusString = Console.ReadLine();
              int radius = int.Parse(radiusString);
              Console.WriteLine("Area of circle = {0:0.00000000}", (Math.PI * (radius * radius)));
              */

            /*  

            Console.Write("Enter a value: ");
            string instring = Console.ReadLine();
            double value = double.Parse(instring);

            double divider = 2;

            Console.WriteLine("your value / " + divider + " = " + (value / divider) + "     " + (value % divider));
            for (int i = 0; i < 20; i=i+1)
            {
                Console.Write(value + i + "/" + divider + " = {0:0.00000}\t\tmodulus = {1:0.00}", ((value + i) / divider), ((value + i) % divider));
                if ((value + i) % 2 == 0)
                {
                    Console.WriteLine("\t" + (value + i) / 2 + "\tEven.");
                }
                else
                {
                    Console.WriteLine("\t" + (value + i) / 2 + "\tOdd.");
                }
            }
            Console.WriteLine("\n\nIs the value divisible by 5 and 7?");


            double x = value;
            bool divisible;
            bool thirdDigit7;
            int valDiv100;

            Console.WriteLine("Value\tBitwise\t\tvalue/5\t\tvalue/7\t\tDivis by 5,7\tThird digit 7");
            for (int i = 0; i < 100; i++)
            {
                divisible =  (x % 5 == 0 && x % 7 == 0);
                valDiv100 = (int)x / 100;
                thirdDigit7 = (valDiv100 == 7);
                {

                    Console.WriteLine("{0}\t{1}\t\t{2:0.00}\t\t{3}\t\t {4}", x , (byte)x , (x/5) , (x/7) , divisible , thirdDigit7);
                    x++;
                }


            }

            */

            // Console.Write("Enter number: ");


            //  int num = Convert.ToInt32(Console.ReadLine());


            PrimeNumbers();

        }
    }
}
