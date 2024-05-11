class Menu
{
    public void StartMenu(ScriptureManager scriptureManager)
    {
        // Display the menu
        string menuChoice = DisplayMenu();

        // Loop until the user chooses to quit
        while (menuChoice != "3")
        {
            switch(menuChoice)
            {
                case "1":
                    // Create a new scripture object
                    scriptureManager.CreateScripture();
                    
                    // Return to the menu
                    menuChoice = "0";
                    break;
                case "2":
                    // Practice memorizing the scripture
                    bool quit = scriptureManager.PracticeScripture();

                    // Return to the menu
                    if (quit)
                    {
                        menuChoice = "0";
                    }
                    break;

                case "3":
                    return;

                case "0":
                    menuChoice = DisplayMenu();
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

    private string DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("-------------- Main Menu --------------");
        Console.Write("\n1. Choose a scripture reference\n2. Practice memorizing\n3. Quit\n-");
        string menuChoice = Console.ReadLine();
        return menuChoice;
    }
}