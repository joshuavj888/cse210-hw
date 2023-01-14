using System;

public class Prompt
{
    public List<string> _promptsList = new List<string>();
    
    public void DisplayRandomPrompt()
    {
        Random random = new Random();
        int randomNum = random.Next(_promptsList.Count);
        Console.WriteLine(_promptsList[randomNum]);
    }
}