class ScriptureManager
{
    private Scripture scripture = new Scripture("John", 3, 16, 0, "For God so loved the world, that he gave his only begotten Sin, that whosoever believeth in him should not perish, but have everlasting life.");
    public string CreateScripture(string choice)
    {
        switch(choice)
        {
            case "1":
                Console.WriteLine("Enter the scripture reference (e.g. John 3:16): ");
                string referenceInput = Console.ReadLine();

                // Split the user input into parts
                string[] parts = referenceInput.Split(' ', ':', '-');

                // Check if the user entered a valid reference
                while (parts.Length < 3 || parts.Length > 5)
                {
                    Console.WriteLine("Invalid reference format. Please enter the reference in the format 'Book Chapter:Verse' or 'Book Chapter:Verse-EndVerse'.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();

                    Console.Clear();

                    Console.WriteLine("Enter the scripture reference (e.g. John 3:16): or type 'quit' to return to the menu");
                    referenceInput = Console.ReadLine();

                    if (referenceInput == "quit")
                    {
                        return "";
                    }
                    parts = referenceInput.Split(' ', ':', '-');
                }

                //If the user entered a valid reference, assign the parts to the appropriate variables
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int verse = int.Parse(parts[2]);
                int endVerse = parts.Length == 4 ? int.Parse(parts[3]) : 0;

                // Create a new reference object
                Reference reference = new Reference(book, chapter, verse, endVerse);

                Console.WriteLine("Enter the scripture text: ");
                string text = Console.ReadLine();

                scripture.Reference = reference;
                scripture.Words = scripture.parseScriptureWords(text);
                

                Console.WriteLine("--Reference loaded--");
                System.Threading.Thread.Sleep(2000);

                return scripture.GetDisplayText();

            case "2": // Select from list
                // clear the console
                Console.Clear();

                // Create a list of scriptures
                List<(string Reference, string Text)> scriptures = new List<(string, string)>
                {
                    ("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
                    ("Matthew 5:14", "Ye are the light of the world. A city that is set on an hill cannot be hid."),
                    ("Proverbs 3:5", "Trust in the Lord with all thine heart; and lean not unto thine own understanding."),
                };

                // Display the list of scriptures
                for (int i = 0; i < scriptures.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {scriptures[i].Reference}");
                }

                // Prompt the user to select a scripture
                Console.WriteLine($"Select a scripture from the list: (1-{scriptures.Count})");
                string selection = Console.ReadLine();

                // Check if the user entered a valid selection
                if (!int.TryParse(selection, out int index) && index > 0 || index <= scriptures.Count)
                {
                    scripture.Reference = new Reference(scriptures[index - 1].Reference, 0, 0);
                    scripture.Words = scripture.parseScriptureWords(scriptures[index - 1].Text);

                    Console.WriteLine("--Reference loaded--");
                    System.Threading.Thread.Sleep(2000);
                }
                // If the user entered an invalid selection
                else
                {
                    Console.WriteLine("Invalid selection");
                }

                return scripture.GetDisplayText();

            case "3":
                // Load a file of scriptures
                Console.WriteLine("Enter the file path: ");
                //string filePath = Console.ReadLine();

                // Check if the file exists

                // Read the file

                // Parse the file

                // Load the scripture

                Console.WriteLine("-- option not currently implemented --");
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();

                // Console.WriteLine("--Reference loaded--");
                // System.Threading.Thread.Sleep(2000);
                
                return scripture.GetDisplayText();

            default:
                Console.WriteLine("Invalid choice");
                return "";
        }
    }

    public bool PracticeScripture()
    {
        bool quit = false;
        scripture.ShowAllWords();

        while (!quit && !scripture.IsCompletelyHidden())
        {
            // Clear the console
            Console.Clear();

            // Display the scripture text with some words hidden
            Console.WriteLine(scripture.GetDisplayText());

            // Prompt the user to enter the scripture text
            Console.WriteLine("Enter the scripture text: (or type quit to return to menu)\n---------------------------\n");

            // Read the user input
            string userText = Console.ReadLine();
            if (userText == "quit")
            {
                quit = true;
            }
            else 
            {
                // Calculate the percentage of words to hide based on the user's input
                scripture.CalculatePercentageOfWordsToHide(userText);

                // Hide the words in the scripture text
                scripture.HideRandomWords(scripture.PercentageOfWordsToHide);
            }
        }

        if (scripture.IsCompletelyHidden())
        {
            // Display congratulatory message
            Console.Clear();
            Console.WriteLine("\nCongratulations! You have successfully memorized the scripture!\n");
            Console.WriteLine("Feel free to practice again or choose a new scripture reference.");

            // Wait for a key press
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }

        // Return to the menu
    quit = true;
    return quit;
    }
}
