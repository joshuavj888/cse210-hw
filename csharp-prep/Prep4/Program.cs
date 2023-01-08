using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string input;
        Boolean listComplete = false;
        int sum = 0;
        double average;
        int largestNum = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do{
            Console.Write("Enter number: ");
            input = Console.ReadLine();
            int inputNum = int.Parse(input);
            if (inputNum == 0)
            {
                listComplete = true;
            }
            else 
            {
                numbers.Add(inputNum);
            }
        } while (listComplete == false);

        foreach (int number in numbers)
        {
            if (number > largestNum)
            {
                largestNum = number;
            }
            sum += number;
        }

        average = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
    } 
}