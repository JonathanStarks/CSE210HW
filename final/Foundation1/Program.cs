using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");

        Console.WriteLine("///////////////Video One///////////////");
        Video video1 = new Video("Clever Video Title", "User_Name", 60);
        Comment comments1 = new Comment();
        video1.DisplayVideo();
        comments1.DisplayComments();
        Console.WriteLine("///////////////////////////////////////");
        Console.WriteLine();

        Console.WriteLine("///////////////Video Two///////////////");
        Video video2 = new Video("Boring Video Title", "Real name of a person", 16524);
        Comment comments2 = new Comment();
        video2.DisplayVideo();
        comments2.DisplayComments2();
        Console.WriteLine("///////////////////////////////////////");
        Console.WriteLine();

        Console.WriteLine("//////////////Video Three//////////////");
        Video video3 = new Video("Missleading Video Title", "Name of someone's Instagram account", 999999);
        Comment comments3 = new Comment();
        video3.DisplayVideo();
        comments3.DisplayComments3();
        Console.WriteLine("///////////////////////////////////////");
    }
}