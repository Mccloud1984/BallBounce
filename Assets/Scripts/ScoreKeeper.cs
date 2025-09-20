using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public Text scoreBox;
    private int currentScore;

    public void AddScore()
    {
        currentScore++;
        scoreBox.text = currentScore.ToString();
    }

    public static ScoreKeeper GetScoreKeeper()
    {
        return GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreKeeper>();
    }
}
