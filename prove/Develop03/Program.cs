using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
    
        
        Referance adamFell = new Referance("2 Nephi", "2", "25");
        Scripture thatManMightBe = new Scripture("Adam fell that man might be and men are that they might have joy", adamFell.Display());
        thatManMightBe.ChopWords();
        
        //adamFell.Display();
        //thatManMightBe.ShowWords();

        //Words execute = new Words("", adamFell, thatManMightBe);
        //execute.theProgram();

        bool running = true;
        while (running = true)
        {

            thatManMightBe.ShowScripture();
            Console.WriteLine();
            //Console.WriteLine("1. Show verse");
            Console.WriteLine("1. Hide words");
            Console.WriteLine("2. Quit");
            Console.Write("--> ");
            string reply = Console.ReadLine();

            if (reply == "1")
            {
                thatManMightBe.HideWords(1);
                Console.Clear();
            }
            else
            {
                running = false;
                return;
            }
        }
    }
}