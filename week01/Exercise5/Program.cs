using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the welcome function
        DisplayWelcome();

        // Call the name prompt and save the return value
        string userName = PromptUserName();

        // Call the number prompt and save the return value
        int userNumber = PromptUserNumber();

        // Call the squaring function and save the result
        int squaredNumber = SquareNumber(userNumber);

        // Call the final display function, passing in the necessary data
        DisplayResult(userName, squaredNumber);
    }

    // 1. Displays the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // 2. Asks for and returns the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // 3. Asks for and returns the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // 4. Accepts an integer and returns its square
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // 5. Accepts name and squared number and displays the result
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}