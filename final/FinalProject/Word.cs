using System;

public class Word
{
    // Attributes
    private string _randomWord;
    private int _index;
    private int _counter;
    private int _rightLetters;
    // Constructors

    // Methods
    public string GetWord()
    {
        Random random = new Random();
        Dictionary dictionary = new Dictionary();

        List<string> calledList = dictionary.GetList();

        _index = random.Next(calledList.Count);
        _randomWord = calledList[_index];

        return _randomWord;
    }
    public int PrintWord(List<char> guessedLetters, String randomWord)
    {
        _counter = 0;
        _rightLetters = 0;
        Console.Write("\r\n");
        foreach (char l in randomWord)
        {
            if (guessedLetters.Contains(l))
            {
                Console.Write(l + " ");
                _rightLetters += 1;
            }
            else
            {
                Console.Write("  ");
            }
            _counter += 1;
        }
        return _rightLetters;
    }
    public int GetWordCount()
    {
        return _randomWord.Length;
    }

}