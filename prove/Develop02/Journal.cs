using System.IO;

public class Journal
{
    public string _filename = "";

    public void WriteToFile(string _filename, List<string> userJournal)
    {
        string fileName = _filename;
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (string journalEntry in userJournal)
            {
                outputFile.WriteLine(journalEntry);
            }
        }
    }

    public List<string> OpenFile(string _filename, List<string> userJournal)
    {
        string fileName = _filename;
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            userJournal.Add(line);
        }

        return userJournal;
    }
}

    