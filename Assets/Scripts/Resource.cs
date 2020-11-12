using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressBeeHive : MonoBehaviour
{

    public int score;


    public int TotalScore
    {
        get=>PlayerPrefs.GetInt(name, 1);
        set => PlayerPrefs.SetInt(name, value);
    }

    public void OnClickUpdateScore()
    {
        TotalScore += GetScore();
    }
    private int GetScore()
    {
        return score;
    }
}
