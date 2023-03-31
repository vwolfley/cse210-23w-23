using System;

public class SimpleScore : ScoringRules
{
    // Attributes
    private bool _status;
    private int _numCorrect = 0;

    // Constructors
    public SimpleScore(int score) : base(score)
    {
        _status = false;
    }
    public SimpleScore(int score, bool status) : base(score)
    {
        _status = status;
    }
    public Boolean Finished()
    {
        return _status;
    }

    // Methods
    // public void GetScore()
    // {
    //     int score = 0;

    //     if (_incorrectGuesses == _maxGuesses)
    //     {
    //         score = 0;
    //     }
    //     else if (_word.Length == _correctGuesses)
    //     {
    //         score = _maxGuesses - _incorrectGuesses;
    //     }
    //     else
    //     {
    //         score = (_correctGuesses * 10) - (_incorrectGuesses * 5);
    //     }

    //     return score;

    // }
    public void ScoreCorrectWord()
    // You can score up to 10 points for each correct word. 
    {

    }

    public void BonusScore()
    // You can score CorrectScoreWord x 2 for each correct word. 
    {

    }

    public void Score()
    // Number of guesses * 3pts
    {

    }


}