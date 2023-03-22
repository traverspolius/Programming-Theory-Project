using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Player // INHERITANCE - parent
{
    private string name;
    private int score;

    public Player()
    {
        name = "Player1";
        score = 0;
    }

    public Player(string name, int score)
    {
        this.name = name;
        this.score = score;
    }

    public string Name // ENCAPSULATION
    { 
        get { return name; } 
        set { name = value; }
    }

    public int Score // ENCAPSULATION
    {
        get { return score; }
        set { score = value; }
    }

    public virtual string GetPlayerInfo()
    {
        string player_info = "";
        player_info = "Name: ";
        player_info += this.name;
        player_info += " \n ";
        player_info += "Score: ";
        player_info += this.score.ToString();
        player_info += " \n ";
        return player_info;
    }
}
