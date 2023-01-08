using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        String userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResults(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static String PromptUserName()
    {
        Console.Write("Please enter your name: ");
        String userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        String input = Console.ReadLine();
        int favNumber = int.Parse(input);
        return favNumber;
    }

    static int SquareNumber(int favNumber)
    {
        int squaredNumber = favNumber * favNumber;
        return squaredNumber;
    }

    static void DisplayResults(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");
    }
}