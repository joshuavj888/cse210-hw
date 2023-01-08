using System;

class Program
{
    static void Main(string[] args)
    {
        Boolean correctGuess = false;
        do 
        {
            Console.Write("What is the magic number? ");
            String input = Console.ReadLine();
            int magicNum = int.Parse(input);
        
            Console.Write("What is your guess? ");
            input = Console.ReadLine();
            int guessNum = int.Parse(input);
        
            if (guessNum > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                correctGuess = true;
            }
        } while (correctGuess == false);
    }
}