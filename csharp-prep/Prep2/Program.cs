using System;

class Program
{
    static void Main(string[] args)
    {
             string input =  Console.ReadLine();
        int studentGrade = int.Parse(input);
        String letter;
        String letterSign = "";

        if (studentGrade >= 90)
        {
            letter =  "A";
        }
        else if (studentGrade >= 80)
        {
            letter =  "B";
        }
        else if (studentGrade >= 70)
        {
            letter =  "C";
        }
        else if (studentGrade >= 60)
        {
            letter =  "D";
        }
        else
        {
            letter =  "F";
        }

                if (studentGrade % 10 >= 7)
        {
            letterSign = "+";
        }
        else if (studentGrade % 10 < 3)
        {
            letterSign = "-";
        }
        
        if (letter == "A" && letterSign == "+")
        {
            letterSign = "";
        }
        else if (letter == "F")
        {
            letterSign = "";
        }

        Console.WriteLine($"Your letter grade is {letter}{letterSign}.");

        Console.WriteLine();
        if (studentGrade >= 70)
        {
            Console.WriteLine("Congradulations, you passed the class!");
        }
        else 
        {
            Console.WriteLine("I am sorry, you didn't pass the class. You will do better next time. You got this!");
        }
    }
}