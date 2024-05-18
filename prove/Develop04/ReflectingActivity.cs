public class ReflectingActivity : Activity
{
    private Timer _timer;
    private bool _timeUp = false;

    public ReflectingActivity()
    {
        Name = "Reflecting Activity";
        Description = 
        "This activity is meant to help you reflect on your past experiences and learn from them.";
        Duration = 60;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("\nWould you like to start the reflecting activity? (y/n) ");
        string response = Console.ReadLine();

        if (response == "y") //Start the activity
        {
            Console.Write("\nHow long would you like to do this activity for? (in seconds) ");
            Duration = Convert.ToInt32(Console.ReadLine());


            Console.Clear();
            DisplayPrompt(GetRandomPrompt());
            
            _timer = new Timer(StopActivity, null, Duration * 1000, Timeout.Infinite);
            while (!_timeUp)
            {
                DisplayQuestion(GetRandomQuestion());
                if (_timeUp) break;
            }
            DisplayEndingMessage();
        }
        else
        {
            Console.WriteLine("Exiting...");
        }
    }


    private string GetRandomPrompt()
    {
        string[] prompts = new string[]
        {
            "Think of a time when you felt proud of yourself.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you served someone in need.",
            "Think of a time when you did something truly selfless.",
        };

        return prompts[new Random().Next(prompts.Length)];
    }

    private string GetRandomQuestion()
    {
        string[] questions = new string[]
        {
            "Why was this experience important to you?",
            "Have you ever had a similar experience?",
            "How did you start this experience?",
            "How did you feel during this experience?",
            "What would you do differently next time?",
            "What did you learn about yourself from this experience?",
            "What did you learn about others from this experience?",
            "What did you learn about the world from this experience?",
            "What did you learn about life from this experience?",
            "What did you learn about love from this experience?",
        };

        return questions[new Random().Next(questions.Length)];
    }

    private void DisplayPrompt(string prompt)
    {
        Console.Clear();
        Console.WriteLine("Ponder on the following prompt:");
        Console.WriteLine($" ----- {prompt} ----- ");

        Console.WriteLine("When you are ready, press any key to continue.");
        Console.ReadKey();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience:");
        Console.Write("Activity beginning in: "); ShowCountDown(5);
        Console.Clear();
    }

    private void DisplayQuestion(string question)
    {
        Console.WriteLine(question);
        ShowSpinner(20);
    }

    private void StopActivity(object state)
    {
        _timeUp = true;
        _timer.Dispose();
        Console.WriteLine("\nTime's up!");
    }
}