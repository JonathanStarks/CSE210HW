
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        //Console.WriteLine("Hello Prep4 World!");
        // Asks for numbers untill the user enters a zero and adds them to the list
        List<int> numbers = new List<int>();
        int user_input = -1;

        do {
        Console.Write("Please enter numbers in whole intigers only: ");
        user_input = int.Parse(Console.ReadLine());
        numbers.Add(user_input);
        } while (user_input != 0);
        
        int total = 0;
        foreach (int number in numbers){
            total += number;
        }
        Console.WriteLine(total);

        
    }
}