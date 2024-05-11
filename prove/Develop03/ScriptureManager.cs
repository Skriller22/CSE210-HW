class ScriptureManager
{
    private Scripture scripture = new Scripture("Book", 0, 0, 0, "Text - if you are seeing this, something went wrong.");
    public string CreateScripture()
    {
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
    }

    public bool PracticeScripture()
    {
        bool quit = false;

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
