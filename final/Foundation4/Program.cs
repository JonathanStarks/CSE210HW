using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation4 World!");

        Running running = new Running("Marathon", 26.22, 7235);
        running.GetSpeed();
        running.GetSummary();

        Console.WriteLine("cycleing===========================");

        Swimming swimming = new Swimming("Swimming", 50, 3600);
        swimming.GetSpeed();
        swimming.GetSummary();

        Console.WriteLine("===================================");
        
        Cycling cycleing = new Cycling("Bike Ride", 5, 4762);
        cycleing.GetSpeed();
        cycleing.GetSummary();
    }
}