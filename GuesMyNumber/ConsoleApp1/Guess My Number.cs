using System;

class GuessMyNumber
{
    static int minValue = 1;
    static int maxValue = 5;

    
    static int inputInteger() //input a value and check it's an integer
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
        int guess, tries;
        float average; 
        int i = rnd.Next(minValue, maxValue);

        Console.WriteLine("Welcome to my program!\n\nI want you to try to guess a number I have thought of.");

        guess = inputInteger();

        tries = 1;
        while (guess != i)
        {

            Console.Write("\nGuess again.\n");
            guess = inputInteger();
            tries++;
        }

        average = maxValue/2;       

        Console.WriteLine("Congratulations! My number was " + i + "\n");
        Console.WriteLine("you took " + tries + " attempts.\n");

        if (tries < average)
            
            Console.WriteLine("That's better than average.\n"); 
        
            else
            
            Console.WriteLine("That's worse than average.\n");
        
        Console.ReadLine();
    }
}
