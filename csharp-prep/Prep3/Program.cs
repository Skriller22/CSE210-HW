using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueGame = true;
        int guessCounter = 0;

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        do
        {

            Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess it?");
            Console.Write("Enter your guess: ");
            int guess = int.Parse(Console.ReadLine());


            if (guess == number)
            {
                Console.WriteLine("You got it!");
                continueGame = false;
            }
            else if (guess > number)
            {
                Console.WriteLine("Too high!");
            }
            else if (guess < number)
            {
                Console.WriteLine("Too low!");
            }

            guessCounter += 1;

        } while (continueGame == true);

        Console.WriteLine($"-It took you {guessCounter} guesses to get it right.-");
    }
}