using System;

class Program
{
    static void Main(string[] args)
    {
        Activity[] activities = new Activity[3];
        activities[0] = new RunningActivity(new DateTime(2022, 2, 22), 60, 5);
        activities[1] = new ByciclingActivity(new DateTime(2022, 2, 22), 60, 10);
        activities[2] = new SwimmingActivity(new DateTime(2022, 2, 22), 60, 20);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

// Polymorphism