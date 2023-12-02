public class Video
{
    string _title;

    string _author;

    int _length;

    

    //string[] _info = new string[];

    public Video(string title, string author, int length)
    {
        _title = title;

        _author = author;

        _length = length;
    }

    public void DisplayVideo()
    {
        Console.WriteLine(_title);
        Console.WriteLine($"By: {_author}");
        Console.WriteLine($"Duration (seconds): {_length}");
    }
}