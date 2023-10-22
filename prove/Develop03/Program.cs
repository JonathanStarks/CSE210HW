using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
    
        
        Referance adamFell = new Referance("2 Nephi", "2", "25");
        Scripture thatManMightBe = new Scripture("Adam fell that man might be and men are that they might have joy", adamFell);
        
        //adamFell.Display();
        thatManMightBe.ShowWords();

        Word execute = new Word("", adamFell);
        execute.theProgram();
    }
}