using System;

class Program
{
    static void Main(string[] args)
    {
        Dvd movie = new Dvd("Star Wars: A New Hope");

        //movie.Display();
        movie.CheckOut();
        movie.Display();

        Book novel = new Book("The Lord Of The Rings", "Yes", 1234);
        novel.Display();
    }
}