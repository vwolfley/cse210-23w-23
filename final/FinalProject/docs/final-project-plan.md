# Final Project Plan

## Project Option Declaration:

I plan to use the open-ended project plan.

## Project Description:

For my project, I plan to create a console log game, Hangman.  Hangman is a simple traditional word-guessing game played by two or more players.   One player thinks of a word and the other players attempt to guess the word by suggesting letters one at a time.   The word is represented by a series of dashes, each dash representing a letter in the word.  The guessing players must correctly guess all the letters in the word to win. 

Each time a player suggests a letter that is not in the word, a part of a “hangman” figure is drawn.  This is typically represented as a gallows and stick figure.  The players lose the game if the entire hangman is drawn before the players are able to correctly guess the word.  This is typically 6 guesses.

In our case, the player will be playing against the computer and a random word generator.  The computer will generate a random word from a list provided.  The player will have 6 guesses to guess the word or the computer wins.  Each wrong guess will lead to a part of the “hangman” being drawn.

The score will be taken as an overall score for the game won.
I will look at adding in letter scores based on scrabble game values.

This game is a great casual game to pass the time, but also a great way to teach vocabulary and spelling words.

### Possible Classes
1. Game
2. Word
3. Dictionary
4. Player (handles the state of the current player's attempt)
5. Renderer (for writing to the console/screen)
6. Scoreboard
7. ScoringRules abstract class
8. SimpleScoring implementation of the ScoreRules abstract class that just scores you based on how many guesses it took
9. ComplexScoring implementation of the ScoreRules abstract class that scores you based on how many guesses it took, but scales the score by the length of the word (so longer words would be harder)
