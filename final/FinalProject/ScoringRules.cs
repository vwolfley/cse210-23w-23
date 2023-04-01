using System;

public abstract class ScoringRules
{
    // Attributes


    // Constructors


    // Methods
    public abstract int CalculateScore(int numGuesses, List<string> letters);

    public abstract void ShowScore();



}