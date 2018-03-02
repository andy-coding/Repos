using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise2  // Write a program in C# Sharp to store elements in an array and print it in revers order.
                          // from: http://www.w3resource.com/csharp-exercises/array/csharp-array-exercise-2.php

{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySum = 0;
            int arrayLength = 0;
            Console.Write("Define Array Length between 1 and 10 : ");
            do
            {
                try
                {
                    arrayLength = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\nInvalid number - try again.");
                }
            } while ((arrayLength < 1) || (arrayLength > 10));

            int [] arr1 = new int[arrayLength];
            int [] arr2 = new int[arrayLength];

            int arrayValue;

            for (int i=0; i<arrayLength; i++)
            {
                Console.WriteLine("Enter value for array number " + i);
                arrayValue = Convert.ToInt32(Console.ReadLine());
                arr1[i] = arrayValue;
                arraySum = arraySum + arrayValue;
            }


            for (int i=0; i < arrayLength; i++)
            {
                arr2[i] = arr1[i];
            }


            Console.WriteLine("Array values in reverse order are:\n");

            for (int i=arrayLength-1; i>-1; i--)
            {
                Console.WriteLine("Array 1 element " + i + " : " + arr1[i] + " and arr 2 element " + i + " = " + arr2[i]);
            }

            Console.WriteLine("Array Sum : " + arraySum);

            Console.ReadLine();

        }
    }
}
