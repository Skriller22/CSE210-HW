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
        Console.WriteLine("Would you like to start the reflecting activity? (y/n)");
        string response = Console.ReadLine();

        if (response == "y") //Start the activity
        {
            Console.WriteLine("How long would you like to do this activity for? (in seconds)");
            Duration = Convert.ToInt32(Console.ReadLine());

            _timer = new Timer(StopActivity, null, Duration * 1000, Timeout.Infinite);

            Console.Clear();
            DisplayPrompt(GetRandomPrompt());
            ShowSpinner(10);

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
        Console.WriteLine(prompt);
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