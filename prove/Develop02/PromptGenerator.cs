using System;

public class promptGenerator
{
    private string[] prompts;

    public promptGenerator()
    {
        prompts = new string[]
        {
            "If you could give your day a color, what would it be and why?",
            "Who influenced your day the most today?",
            "What are you most anxious for in the future?",
            "What is your favorite thing about yourself?",
            "How are you accomplishing your goals today?",
            "What was your least favorite part of the day?",
            "If you could change one thing about today, what would it be?",
            // Add more prompts here
        };
    }

    public string SelectRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}