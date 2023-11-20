using System;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        //Console.WriteLine("Hello Develop05 World!");

        bool running = true;

        while (running == true)
        {
            Console.Clear();
            Console.WriteLine("----Main Menu----");
            Console.WriteLine("Please enter a numebr from the list below:");
            Console.WriteLine("1) Basic goal menu");
            Console.WriteLine("2) Eternal goal menu");
            Console.WriteLine("3) Checklist goal menu");
            Console.WriteLine("4) View Points");
            Console.WriteLine("5) Quit program");

            Console.Write("->");
            int answer = System.Int32.Parse(Console.ReadLine());
            if (answer == 1)
            {
                Basic execute = new Basic("Basic", "Description", 0);
                execute.GoalSubMenu();
            }
            else if (answer == 2)
            {
                Eternal execute = new Eternal("Eternal", "Description", 0);
                execute.GoalSubMenu();
            }
            else if (answer == 3)
            {
                Checklist execute = new Checklist("Checklist", "Description", 0);
                execute.GoalSubMenu();
            }
            else if (answer == 4)
            {
                Goal execute = new Goal("", "", 0);
                execute.LoadPoints();
            }
            else
            {
                return;
            }
        }
    }
}