using System;

public class promptGenerator
{
    private string[] prompts;

    public promptGenerator()
    {
        prompts = new string[]
        {
            "Write about a memorable childhood experience.",
            "Describe a person who has had a significant impact on your life.",
            "What is your biggest fear and why?",
            "Discuss a book or movie that has influenced you.",
            "Write about a time when you overcame a challenge.",
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