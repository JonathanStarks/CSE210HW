public class Book
{
    private string _author;
    private string _name;
    private int _timesRead;
    private bool _available;

    public List<> shelf = new List<>()
    {
        Book{
            ("Moroni", "The Book Of Mormon"),
            ("Tolken", "The Lord Of The Rings")
    };
    
    public Book (string author, string name)
    {
        _author = author;
        _name = name;
        _timesRead = 0;
        _available = true;
    }

    public int TimesRead()
    {
        return _timesRead;
    }
    
    public void CheckOut()
    {
        _timesRead += 1;
        _available = false;
    }

    public void CheckIn()
    {
        _available = true;
    }

    public bool HasAuthor(string author)
    {
        return _author.Contains(author);
    }

    public void DisplayBook()
    {
        Console.WriteLine($"Title: {_name}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Times Read: {_timesRead}");
        Console.WriteLine($"Available: {_available}");
    }
}