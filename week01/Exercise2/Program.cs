using System;

class Program
{
    static void Main(string[] args)
    {
        // --- Core Requirement 1: Get User Input ---
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        // --- Core Requirement 3: Determine Letter Grade ---
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // --- Stretch Challenge: Determine the Sign (+ or -) ---
        string sign = "";
        int lastDigit = percent % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // --- Stretch Challenge: Handle Exceptional Cases (A+, F+, F-) ---
        if (letter == "A" && sign == "+")
        {
            sign = ""; // No such thing as an A+
        }

        if (letter == "F")
        {
            sign = ""; // No such thing as F+ or F-
        }

        // --- Final Output of Grade ---
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // --- Core Requirement 2: Pass/Fail Message ---
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Better luck next time.");
        }
    }
}