using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        // Guess the number game. User enters a number and then tries to guess the number while being told higher or lower.
        Console.Write("Enter the magic number: ");
        int magic_number = int.Parse(Console.ReadLine());

        Console.Write("Enter your number guess: ");
        int user_guess = int.Parse(Console.ReadLine());

        do {
            if (user_guess > magic_number) {
                Console.WriteLine("That's too high.");
            }
            else if (user_guess < magic_number) {
                Console.WriteLine("That's too low");
            }
            Console.Write("Enter your number guess: ");
            user_guess = int.Parse(Console.ReadLine());
            
        }
        while (magic_number != user_guess);

        Console.WriteLine("That's it! That's the number!");
    }
}