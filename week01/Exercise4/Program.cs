using System;
using System.Collections.Generic; // Required for Lists
using System.Linq;               // Required for advanced operations like Sort

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // --- Data Entry Loop ---
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // --- Core Requirement 1: Compute Sum ---
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // --- Core Requirement 2: Compute Average ---
        // We cast sum to float to ensure we get decimal points in the result
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // --- Core Requirement 3: Find Maximum ---
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // --- Stretch Challenge 1: Smallest Positive Number ---
        int smallestPositive = int.MaxValue; // Start with a very large number
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // --- Stretch Challenge 2: Sorting ---
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}