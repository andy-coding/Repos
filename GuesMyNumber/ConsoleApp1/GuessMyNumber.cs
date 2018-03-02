using System;

class GuessMyNumber
{
    static int minValue = 1;
    static int maxValue = 5;

    static int inputInteger()
    {

        string inputString;
        int i;
 
        Console.WriteLine("Input an integer.\n");
        inputString = Console.ReadLine();
        i = int.Parse(inputString);
        return i;
    }

    public static void Main()
    {
        Random rnd = new Random();
        int guess;
        int i = rnd.Next(minValue, maxValue);

        Console.WriteLine("Welcome to my program!\n\nI want you to try to guess a number I have thought of.");

        guess = inputInteger();


        while (guess != i)
        {

            Console.Write("\nGuess again.\n");
            guess = inputInteger();
        }

            

    Console.WriteLine("Congratulations! My number was " + i);

    
    Console.ReadLine();

    }
}
