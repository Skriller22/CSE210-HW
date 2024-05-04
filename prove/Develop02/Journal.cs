public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private promptGenerator promptGenerator;
    private string loadFile;

    public Journal()
    {
        this.promptGenerator = new promptGenerator();
        this.entries = new List<Entry>();
    }

    public void initialize()
    {
        ChangeLoadFile();
    }

    public void WriteEntry()
    {
        // Generate a random prompt and collect curent date
        string prompt = promptGenerator.SelectRandomPrompt();
        DateTime now = DateTime.Now;

        // Display the prompt and collect the entry text
        Console.WriteLine($"{now.ToShortDateString()} - Prompt: {prompt}");
        string entryInput = Console.ReadLine();

        // Format the entry and add it to the list
        Entry newEntry = new Entry(now.ToShortDateString(), prompt, entryInput);
        entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        // Display all entries or a message if there are none
        if (entries.Count > 0)
        {
            Console.WriteLine("Entries:");
            foreach (Entry e in entries)
            {
                e.DisplayEntry(); // Call the DisplayEntry() method on the instance of Entry
            }
        }
        else
        {
            Console.WriteLine("No entries found.");
        }
    }

    public void ChangeLoadFile()
    {
        string newloadfile;
        bool fileLoaded = false;

        // Loop until a valid file is loaded
        while (!fileLoaded)
        {
            // Prompt the user to enter a new file name
            Console.WriteLine("Enter the file name to load entries from:");
            newloadfile = Console.ReadLine();

            // If the file exists, update the load file
            if (File.Exists(newloadfile))
            {
                loadFile = newloadfile;
                Console.WriteLine("File loaded.");
                fileLoaded = true;
            }
            else
            // If the file does not exist, prompt the user to create a new file
            {
                Console.WriteLine("File not found. Create a new file? (y/n)");
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    File.Create(newloadfile).Close();
                    loadFile = newloadfile;
                    Console.WriteLine("New file created and loaded.");
                    fileLoaded = true;
                }
            }
        }

        //After loading file, read all entries from the file
        readFile();
    }

    public void SaveToFile()
    {
        // Save all entries to a file
        writeFile();
        Console.WriteLine("Entries saved.");
    }

    private void readFile()
    {
        // Read all entries from the file
        entries = File.ReadAllLines(loadFile).Select(e => Entry.ParseEntry(e)).ToList();
    }

    private void writeFile()
    {
        // Write all entries to the file
        File.WriteAllLines(loadFile, entries.Select(e => e.FormatEntryForFile()));
    }
}