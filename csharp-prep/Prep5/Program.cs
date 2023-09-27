using System;

class Program
{
    static void Main(string[] args)
    {
        show_message();
        string user_name = ask_user();
        int number = fav_number();
        int final_number = squared(number);
        
        answer(user_name, final_number);

        //Console.WriteLine("Hello Prep5 World!");

        static void show_message() {
            Console.WriteLine("Welcome to the void!");
        }

        static string ask_user() {
            Console.Write("What's your name: ");
            string user_name = Console.ReadLine();
            return user_name;
        }

        static int fav_number() {
            Console.Write("What's your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int squared(int number) {
            int final_number = number * number;
            return final_number;
        }

        static void answer(string user_name, int final_number) {
            Console.WriteLine($"Hello, {user_name}, the square of your favorite number is {final_number}.");
        }

        
    }
}