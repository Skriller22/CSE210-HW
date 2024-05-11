using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a new scripture object
        Scripture scripture = new Scripture("Book", 1, 1, "ScriptureText - If you are seeing this, something went wrong.");

        {
            // Display the main menu
            Console.Clear();
            Console.WriteLine("-------------- Main Menu --------------");
            Console.Write("\n1. Choose a scripture reference\n2. Practice memorizing\n3. Quit\n-");
            string menuChoice = Console.ReadLine();

            // Validate the user input
            while (menuChoice != "1" && menuChoice != "2" && menuChoice != "3")
            {
                Console.WriteLine("Invalid choice");
                Console.Write("\n1. Choose a scripture reference\n2. Practice memorizing\n3. Quit\n-");
                menuChoice = Console.ReadLine();
            }

            // Process the user's choice
            while (menuChoice != "3")
            {

                switch(menuChoice)
                {
                    case "1":
                        Console.WriteLine("Enter the scripture reference (e.g. John 3:16): ");
                        string referenceInput = Console.ReadLine();

                        // Split the user input into parts
                        string[] parts = referenceInput.Split(' ', ':');
                        string book = parts[0];
                        int chapter = int.Parse(parts[1]);
                        int verse = int.Parse(parts[2]);

                        // Create a new reference object
                        Reference reference = new Reference(book, chapter, verse);

                        Console.WriteLine("Enter the scripture text: ");
                        string text = Console.ReadLine();

                        scripture.Reference = reference;
                        scripture.Words = scripture.parseScriptureWords(text);
                        

                        Console.WriteLine("--Reference loaded--");
                        System.Threading.Thread.Sleep(2000);

                        // Return to the menu
                        menuChoice = "0";

                        break;

                    case "2":
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
                                menuChoice = "0";
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
                            Console.WriteLine("Congratulations! You have successfully memorized the scripture.");
                            Console.WriteLine("Feel free to practice again or choose a new scripture reference.");
                            Console.WriteLine("Press any key to return to the main menu.");

                            // Wait for a key press
                            Console.ReadKey();

                            // Return to the menu
                            menuChoice = "0";
                            break;
                        }

                        break;

                    case "3":
                        return;

                    case "0":
                        Console.Clear();
                        Console.WriteLine("-------------- Main Menu --------------");
                        Console.Write("\n1. Choose a scripture reference to memorize\n2. Practice memorizing\n3. Quit\n-");
                        menuChoice = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        
                        // sleep for 1 second
                        System.Threading.Thread.Sleep(1000);

                        //return to the menu
                        menuChoice = "0";
                        break;


                }
            }
        }

    }
}