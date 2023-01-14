using System;

class Program
{
    static void Main(string[] args)
    {
        // Create variable to loop menu until the user quites.
        Boolean complete = false;

        // Create the list of prompts used for journal entries.
        Prompt journalPrompts = new Prompt();
        journalPrompts._promptsList.Add("What was the most interesting person I interacted with today?");
        journalPrompts._promptsList.Add("What was the best part of my day?");
        journalPrompts._promptsList.Add("How did I see the hand of the Lod in my life today?");
        journalPrompts._promptsList.Add("What was the strongest emotion I felt today?");
        journalPrompts._promptsList.Add("If I had one thing I could do over today, what would it be?");
        journalPrompts._promptsList.Add("How have I been blessed today?");
        journalPrompts._promptsList.Add("What was the best tasting thing I ate today?");
        journalPrompts._promptsList.Add("What experience brought me joy today?");
        
        // Creath the journal list. 
        List<string> userJournal = new List<string>();

        Console.WriteLine("Welcome to the Journal Program!");

        // Begin program loop
        do
        {  
            // Display the menu to the user.
            Menu inputMenu = new Menu();
            inputMenu.DisplayMenu();

            // Get menu selection from the user.
            String userInput = Console.ReadLine();
            int userChoice = int.Parse(userInput);

            // Perform the necessary action.
            if (userChoice == 1)
            {
                    // Provide a random prompt to the user for a new journal entry and store the users response.
                    Random random = new Random();
                    int randomNum = random.Next(journalPrompts._promptsList.Count());
                    Console.WriteLine(journalPrompts._promptsList[randomNum]);
                    userJournal.Add(Console.ReadLine());
            }

            else if (userChoice == 2)
            {
                // Display the jounral entries to the user.
                foreach (string journalEntry in userJournal)
                {
                    Console.WriteLine(journalEntry);
                }
            }

            else if (userChoice == 3)
            {
                // Load a file to the userJournal.
                Console.Write("Please enter the file name: ");
                string fileName = Console.ReadLine();
                Journal myJournal = new Journal();
                userJournal = myJournal.OpenFile(fileName, userJournal);
            }

            else if (userChoice == 4)
            {
                // Save the journal entries to a file.
                Console.Write("Please enter the file name: ");
                string fileName = Console.ReadLine();
                Journal myJournal = new Journal();
                myJournal.WriteToFile(fileName, userJournal);
            }

            else if (userChoice == 5)
            {
                // changes the value of the complete variable to end the program.
                complete = false;
            }

        } while (complete == false);

            // Display Menu
    }
}