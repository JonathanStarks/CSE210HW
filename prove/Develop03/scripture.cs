using System.ComponentModel;
using System.Net.Sockets;

public class Scripture {
    Referance _referance;

    public List<Word> _scripture = new List<Word>();

    public Scripture(string word, Referance referance){
        _referance = referance;

        string[] verses = word.Split(" ");
        foreach (string part in verses)
        {
            _scripture.Add(new Word(part, referance));
        }
    }

    // Randomly chooses a word to be used in the Hide method
    public void HideWords()
    {
        Random randomNumber = new Random();
        Int32 listLength = _scripture.Count;
        //int thisManyTimes = randomNumber.Next(5);
        for (randomNumber.Next(5);;)
        {
            _scripture = new _scripture.Replace(_scripture.IndexOf(null, randomNumber.Next(listLength)), "_");

        }
        
    }

    // Checks to see if all the words are hidden, if they are all hidden the program will end
    public void ShowWords(){
        _referance.Display();
        foreach (Word word in _scripture)
        {
            word.Display();
        }
    }

    
}