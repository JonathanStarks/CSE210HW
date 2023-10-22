public class Word {
    private string _word;

    Referance _referance;
    
    public Word(string word, Referance referance){
        _word = word;
        _referance = referance;

    }

    public void Display()
    {
        Console.Write($"{_word} ");
    }
    // Hides a word and replaces it with underscores, one per letter.
    public void Hide(){

    }

    // Reverses the hide method.
    public void Show(){

    }

    public void theProgram()
    {
        bool running = true;
        while (running == true)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Show Scripture");
            Console.WriteLine("2) Remove some words");
            Console.WriteLine("3) End program");
            Console.Write("--> ");

            string answer = Console.ReadLine();
            Console.Clear();
            if (answer == "1")
            {
                _referance.Display();
                
            }
            else if (answer == "2")
            {
                
            }
            else
            {
                running = false;
            }
        }
    }
}