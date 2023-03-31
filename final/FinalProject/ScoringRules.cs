using System;

public abstract class ScoringRules
{
    // Attributes
    private int _score;
    private Player player;


    // Constructors
    public ScoringRules(int score)
    {
         player = new Player();
         _score = score;
    }
    

    // Methods
    // public abstract int GetScore();
    

}