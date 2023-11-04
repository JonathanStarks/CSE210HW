using System.ComponentModel;
using System.Net.Sockets;
using System.Text.RegularExpressions;

public class Scripture {

    string _verse;

    string _reference;

    public string[] _wordList;

    public Scripture(string verse, string referance)
    {
        _verse = verse;
        _reference = referance;
    }

    public void ChopWords()
    {
        _wordList = _verse.Split(" ");
    }

    public void ShowScripture()
    {
        Console.WriteLine(_reference);
        foreach (string word in _wordList)
        {
            Console.Write($"{word} ");
        }
    }

    public void HideWords(int numberOfTimes)
    {
        for (int i = 0; i < numberOfTimes; i++)
        {
            Random rnd = new Random();
            int index = (int) rnd.Next(0, _wordList.Length);
            string word = _wordList[index];
            if (Regex.IsMatch(word, "[_]"))
            {
                i -= 1;
            }
            else
            {
                Words hide = new Words(word);
                _wordList[index] = hide.Hide(word);
            }
        }
    }
/*
    Referance _referance;

    public List<Word> _scripture = new List<Word>();

    public Scripture(string word, Referance referance){
        _referance = referance;

        /*string[] verses = word.Split(" ");
        foreach (string part in verses)
        {
            _scripture.Add(new Word(part, referance));
        }
        
    }

    // Randomly chooses a word to be used in the Hide method
    public static void HideWords()
    {
        Random randomNumber = new Random();
        //int listLength = _scripture.Count;
        int thisManyTimes = randomNumber.Next(3);
        int i = 0;
        while (i != thisManyTimes)
        {
            //Scripture _scripture = new _scripture.Replace(_scripture.IndexOf(null, randomNumber.Next(listLength)), "_");
            
            i++;
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
    */
    
}