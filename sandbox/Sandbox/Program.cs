using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Console.Write("What's your name: ");
        string user_name = Console.ReadLine();
        Console.WriteLine("Hello, " + user_name + "!");
        Console.WriteLine($"Hello, {user_name}!");
    }
}