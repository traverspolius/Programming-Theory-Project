using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryMatchPlayer : Player // INHERITANCE - child
{
    // The score values for the game ranking information.
    private const int MAX_SCORE = 100;
    private const int HIGH_SCORE = 90;
    private const int MED_SCORE = 75;
    private const int MIN_SCORE = 50;

    private int gameGuesses;

    public MemoryMatchPlayer()
    {
        gameGuesses = 0;
    }

    public MemoryMatchPlayer(int gameGuesses)
    {
        this.gameGuesses = gameGuesses;
    }

    public int GameGuesses // ENCAPSULATION
    {
        get { return gameGuesses; }
        set { gameGuesses = value; }
    }

    public override string GetPlayerInfo()// POLYMORPHISM
    {
        string player_info = this.GetScoreRank() + " \n" + base.GetPlayerInfo();
        player_info += "Total Guesses: ";
        player_info += this.GameGuesses.ToString();
        return player_info;
    }

    private string GetScoreRank() // ABSTRACTION
    {
        int score = GetCalculatedScore(); // ABSTRACTION
        string scoreRank = "Try Again :(";

        if (score > 0)
        {
            if (score > HIGH_SCORE)
                scoreRank = "Awesome work!";
            else if (score > MED_SCORE && score < HIGH_SCORE)
                scoreRank = "Good job :)";
            else if (score > MIN_SCORE && score < MED_SCORE)
                scoreRank = "Not bad but not great.";

            this.Score = score;
        }

        return scoreRank;
    }

    public int GetScore()
    {
        int temp_score = MAX_SCORE;

        if (this.GameGuesses > 0)
            temp_score = GetCalculatedScore();

        return temp_score;
    }

    private int GetCalculatedScore()
    {
        return MAX_SCORE - this.GameGuesses;
    }
}
