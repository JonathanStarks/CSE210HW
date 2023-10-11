public class Bookcase
{
    public void ShowBooks()
    {
        foreach (book b in shelf)
        {
            Book.DisplayBook();
        }
    }
}