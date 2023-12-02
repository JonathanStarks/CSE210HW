public class Comment
{
    List<string> _comments1 = new List<string>
    {
        "XX_Cool User Name_XX: This is a comment on the first video.",
        "Generic User Name: This is another comment on the first video.",
        "No Idea User Name: This is the last comment on the first video."
    };

    public void DisplayComments()
    {
        Console.WriteLine($"Number of comments: {_comments1.Count}");
        Console.WriteLine("----------Video One Comments----------");
        foreach (string c in _comments1)
        {
            Console.WriteLine(c);
        }
    }

    List<string> _comments2 = new List<string>
    {
        "XX_Cool User Name_XX: This is a comment on the second video.",
        "Generic User Name: This is another comment on the second video.",
        "No Idea User Name: This is the last comment on the second video.",
        "Another User Name: This is deffinitely a comment on a video."
    };

    public void DisplayComments2()
    {
        Console.WriteLine($"Number of comments: {_comments2.Count}");
        Console.WriteLine("----------Video Two Comments----------");
        foreach (string c in _comments2)
        {
            Console.WriteLine(c);
        }
    }

    List<string> _comments3 = new List<string>
    {
        "XX_Cool User Name_XX: This is a comment on the second video.",
        "Generic User Name: This is another comment on the second video.",
        "No Idea User Name: This is the last comment on the second video.",
        "Yet Another User Name: Yup, this is a comment.",
        "Last User Name: This is to show that the program actually does tell how many comments are in this list."
    };

    public void DisplayComments3()
    {
        Console.WriteLine($"Number of comments: {_comments3.Count}");
        Console.WriteLine("---------Video Three Comments---------");
        foreach (string c in _comments3)
        {
            Console.WriteLine(c);
        }
    }
    // public Comment(List<string> comments)
    // {
    //     _comments = comments;
    // }

        
}