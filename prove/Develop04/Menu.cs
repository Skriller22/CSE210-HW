public class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("1. Reflecting Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Breathing Activity");
        Console.WriteLine("4. Exit");
    }

    public void Run()
    {
        DisplayMenu();
        int choice = 0;
        while (choice != 4)
        {
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    reflectingActivity.ShowCountDown(reflectingActivity.Duration);
                    reflectingActivity.ShowSpinner(reflectingActivity.Duration);
                    reflectingActivity.DisplayEndingMessage();
                    break;
                case 2:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    listingActivity.ShowCountDown(listingActivity.Duration);
                    listingActivity.ShowSpinner(listingActivity.Duration);
                    listingActivity.DisplayEndingMessage();
                    break;
                case 3:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    breathingActivity.ShowCountDown(breathingActivity.Duration);
                    breathingActivity.ShowSpinner(breathingActivity.Duration);
                    breathingActivity.DisplayEndingMessage();
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
}