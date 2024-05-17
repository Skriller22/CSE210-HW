public class ReflectingActivity : Activity
{
    public ReflectingActivity()
    {
        Name = "Reflecting Activity";
        Description = "Reflecting on the activity";
        Duration = 5;
    }

    public void Run()
    {
        Console.WriteLine("Reflecting activity");
    }

    public string GetRandomPrompt()
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

    public string GetRandomQuestion()
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

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine(prompt);
    }

    public void DisplayQuestion(string question)
    {
        Console.WriteLine(question);
    }
}