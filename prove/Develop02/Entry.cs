public class Entry
{
    // Properties to store the entry data
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string EntryText { get; set; }

    // Constructor to initialize the properties
    public Entry(string date, string prompt, string entryText)
    {
        Date = date;
        Prompt = prompt;
        EntryText = entryText;
    }

    // Method to format the entry for display
    public string FormatEntryForDisplay()
    {
        return $"Date: {Date} Prompt: {Prompt} \nEntry:\n{EntryText}\n";
    }

    // Method to format the entry for saving to a file
    public string FormatEntryForFile()
    {
        return $"{Date}-{Prompt}-{EntryText}";
    }

    // Method to display the entry
    public void DisplayEntry()
    {
        Console.WriteLine(FormatEntryForDisplay());
    }

    //Method to parse entries from a string
    public static Entry ParseEntry(string entryString)
    {
        // Split the entry string into date, prompt, and entry text
        string[] entryParts = entryString.Split('-');

        // Check if the entry string is formatted correctly
        if (entryParts.Length != 3)
        {
            throw new FormatException("File could not be read. Invalid entry format.");
        }
        // Trim any leading or trailing whitespace from the parts
        entryParts[0] = entryParts[0].Trim();
        entryParts[1] = entryParts[1].Trim();
        entryParts[2] = entryParts[2].Trim();

        // Create a new Entry object with the parsed data
        Entry newEntry = new Entry(entryParts[0], entryParts[1], entryParts[2]);
        return newEntry;
    }
}