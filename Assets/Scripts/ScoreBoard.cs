using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public Text ScoreText;
    private int Score;
    public int ScorePerSecond;
    public int SecondsBetweenScores;


    private void Start()
    {
        AddTimerScore();
    }
    public void UpdateScoreBoard(int val)
    {
        if(Time.timeScale > 0)
        {
            Score += val;
            ScoreText.text = "Score: " + Score;
        }
    }
    void AddTimerScore()
    {
        UpdateScoreBoard(ScorePerSecond);
        Invoke("AddTimerScore", SecondsBetweenScores);
    }
}
