using System;

public class ComplexScore : ScoringRules
{
    // Attributes
    private bool _status;

    Dictionary<string, int> scrabble = new Dictionary<string, int>()
        {
            {"e", 1},
            {"a", 1},
            {"i", 1},
            {"o", 1},
            {"n", 1},
            {"r", 1},
            {"t", 1},
            {"l", 1},
            {"s", 1},
            {"u", 1},
            {"d", 2},
            {"g", 2},
            {"b", 3},
            {"c", 3},
            {"m", 3},
            {"p", 3},
            {"f", 4},
            {"h", 4},
            {"v", 4},
            {"w", 4},
            {"y", 4},
            {"k", 5},
            {"j", 8},
            {"x", 8},
            {"q", 10},
            {"z", 10}
        };


    // Constructors
    public ComplexScore(int points) : base(points)
    {
        _status = false;
    }
    public ComplexScore(int points, bool status) : base(points)
    {
        _status = status;
    }
    public Boolean Finished()
    {
        return _status;
    }

    // Methods
    public void WordSizeScore()
    /* 
    You can score per size of word
     <= 7 letters 2pts
     > 7 & <= 10 letters 4pts
     > 10 & <= 12 letters 6pts
     >12 & <= 14 letters 8pts
     > 14 letters 10pts
     */
    {

    }

    public void ScoreComplex()
    // Number of guesses * 3pts
    // Plus 1 pt for each letter in the word
    {

    }

    public void ScrabbleScore()
     // Number of guesses * 3pts
     // Plus letter value for each letter in the word guessed
    {

    }




}