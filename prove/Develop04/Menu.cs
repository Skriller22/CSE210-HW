public class Menu
{
    public void MenuChoices()
    {
        int choice = 0;
        while (choice != 4)
        {
            DisplayMenu();
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case 2:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case 3:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    private void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Reflecting Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Breathing Activity");
        Console.WriteLine("4. Exit");
    }
}