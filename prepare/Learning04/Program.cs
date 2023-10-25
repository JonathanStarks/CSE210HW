using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        Assignments execute = new Assignments("Jonathan", "Computer Science");
        MathAssignments things = new MathAssignments("Chapter 47", "1 - 98", "Jonathan", "Computer Science");
        WritingAssignments other = new WritingAssignments("Book title here", "Jonathan", "computer science");

        execute.GetSummary();
        Console.WriteLine();
        things.DisplayMath();
        Console.WriteLine();
        other.DisplayWrit();
    }
}