public class Referance {
    private string _book;

    private string _chapter;

    private string _verse;

    
    public Referance(string book, string chapter, string verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    
    public void Display(){
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
        
    }
}