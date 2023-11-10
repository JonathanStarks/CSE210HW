using System;

class Program
{
    

    
    static void Main(string[] args)
    {
        Breathe breath = new Breathe("breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. The timer will run four times.", 5);

        Reflection reflect = new Reflection("reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. The timer will run for as long as you set it to.", 5);

        Listen listening = new Listen("listening", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 5);

        bool running = true;
        while (running == true)
        {
            Console.WriteLine("Welcome to the mindfulness program, please select an option to get started: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listening Activity");
            Console.WriteLine("4. Quit");
            Console.Write("--> ");

            int response = Int32.Parse(Console.ReadLine());

            if (response == 1)
            {
                breath.BreathingInstructions();
                
            }
            else if (response == 2)
            {
                reflect.ReflectionInstructions();
            }
            else if (response == 3)
            {
                listening.ListeningInstructions();
            }
            else
            {
                running = false;
            }
        }
    }
}