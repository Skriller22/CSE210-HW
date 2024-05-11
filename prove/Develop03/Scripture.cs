public class Scripture
{
    public Reference Reference { get; set; }
    public List<Word> Words { get; set; }
    public int PercentageOfWordsToHide { get; set; }

    public Scripture(string book, int chapter, int verse, string words)
    {
        Reference = new Reference(book, chapter, verse);
        Words = parseScriptureWords(words);

        PercentageOfWordsToHide = 0;
    }

    public void HideRandomWords(int percentageOfWordsToHide)
    {
            // Hide randoms word in the Words property
        if (percentageOfWordsToHide < 0 || percentageOfWordsToHide > 100)
        {
            throw new ArgumentException("Percentage of words to hide must be between 0 and 100");
        }

        int numberOfWordsToHide = (int)Math.Ceiling(Words.Count * percentageOfWordsToHide / 100.0);

        // Shuffle a list of indeces for each word using the Fisher-Yates algorithm
        // https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
        // author note: I'm not sure how it works exactly but basically it shuffles the list of indeces representing each word in the list
        List<int> indeces = Enumerable.Range(0, Words.Count).ToList();
        Random rng = new Random();
        int n = indeces.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            var value = indeces[k];
            indeces[k] = indeces[n];
            indeces[n] = value;
        }

        // Hide the first N indeces in the shuffled list
        for (int i = 0; i < numberOfWordsToHide; i++)
        {
            Words[indeces[i]].Hide();
        }
    }

    public List<Word> parseScriptureWords(string words)
    {
        List<Word> wordList = new List<Word>();
        foreach (string word in words.Split(' '))
        {
            wordList.Add(new Word(word));
        }

        return wordList;
    }

    public string GetDisplayText()
    {
        // Return the display reference of the Reference property
        string referenceText = Reference.DisplayText + "\n";

        // Return the display text of the Words property
        return referenceText + string.Join(" ", Words.Select(w => w.GetDisplayText()));

    }

    public bool IsCompletelyHidden()
    {
        return Words.All(w => w.isHidden);

    }

    public void CalculatePercentageOfWordsToHide(string userText)
    {
        // Split user input into words
        string[] userInput = userText.Split(' ');

        // Check if the lengths are the same
        if (userInput.Length != Words.Count)
        {
            Console.WriteLine("The number of words entered does not match the number of words in the scripture.");
            Console.WriteLine("Press any key to continuee...");

            //wait for a key press
            Console.ReadKey();
            
            return;
        }

        // Compare each word in the user input to the corresponding word in the scripture
        int correctWords = 0;
        for (int i = 0; i < Words.Count; i++)
        {
            if (Words[i].Text == userInput[i])
            {
                correctWords++;
            }
        }

        // Calculate the success rate
        double successRate = calculateSuccessRate(userInput);

        // Calculate the percentage of words to hide based on the user's success rate
        if (successRate >= 0.9)
        {
            PercentageOfWordsToHide = PercentageOfWordsToHide + 20;
        }
        else if (successRate >= 0.5)
        {
            PercentageOfWordsToHide = PercentageOfWordsToHide + 5;
        }
        else
        {
            PercentageOfWordsToHide = PercentageOfWordsToHide - 5;
        }
    }

    private double calculateSuccessRate(string[] userInput)
    {
        // Compare each word in the user input to the corresponding word in the scripture
        int correctWords = 0;
        for (int i = 0; i < Words.Count; i++)
        {
            if (Words[i].Text == userInput[i])
            {
                correctWords++;
            }
        }

        // Calculate the success rate
        return (double)correctWords / (double)Words.Count;
    }
}