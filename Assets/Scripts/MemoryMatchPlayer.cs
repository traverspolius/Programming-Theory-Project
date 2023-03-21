using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryMatchPlayer : Player // INHERITANCE - child
{
    private int gameGuesses;

    public MemoryMatchPlayer()
    {
        gameGuesses = 0;
    }

    public MemoryMatchPlayer(int gameGuesses)
    {
        this.gameGuesses = gameGuesses;
    }

    public int GameGuesses
    {
        get { return gameGuesses; }
        set { gameGuesses = value; }
    }

    public override string GetPlayerInfo()// POLYMORPHISM
    {
        string player_info = base.GetPlayerInfo();
        player_info += "/n";
        player_info += "Total Gueses: ";
        player_info += this.gameGuesses.ToString();
        return player_info;
    }
}
