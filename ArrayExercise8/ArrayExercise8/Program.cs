using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0;

            Console.Write("How many elements in the array? ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int a=0; a<n; a++)
            {
                Console.Write("Enter the value for element {0} : ");
                arr[a] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("-----------------------\n");

            Console.WriteLine("Unique values are:\n");


            for (int i=0; i<n; i++)
            {
                int ctr = 1;
                for (int j=i+1; j<n; j++)
                {


                    if (arr[i] == arr[j])
                    {
                        ctr++;
                    }
                }
                if (ctr == 1)
                {
                    Console.Write(ctr + " ");
                }

            }
            Console.ReadLine();
        }
    }
}
