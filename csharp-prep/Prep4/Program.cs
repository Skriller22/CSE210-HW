using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 to stop");

        //loop start
        do
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        } while (true);
        //loop end

        //calculate sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        //calculate average
        //avoid div/0 error with if statement
        double average = 0;
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered");
            return;
        }
        else
        {
            average = (double)sum / numbers.Count;
        }

        //find max
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        //output
        Console.WriteLine($"The sum of the numbers is {sum}");
        Console.WriteLine($"The average of the numbers is {average:F2}");
        Console.WriteLine($"The largest number is {max}");
    }
}