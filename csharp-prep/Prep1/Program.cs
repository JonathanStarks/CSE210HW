using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        // Asks the user for their first name
        Console.Write("What's your first name: ");
        string first_name = Console.ReadLine();

        // Asks the user for their last name
        Console.Write("What's your last name: ");
        string last_name = Console.ReadLine();

        // Displays the user's name in a james bond quote
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}