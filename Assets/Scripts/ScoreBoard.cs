using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public Text ScoreText;
    public Text HighScore;

    private int Score;
    public int ScorePerSecond;
    public int SecondsBetweenScores;


    private void Start()
    {
        AddTimerScore();
        HighScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    public void UpdateScoreBoard(int val)
    {
        if(Time.timeScale > 0)
        {
            Score += val;
            ScoreText.text = "Score: " + Score;
        }
    }
    public void CheckForHighScore()
    {
        if (Score > PlayerPrefs.GetInt("HighScore", 0))
        {
            HighScore.text = "High Score: " + Score;
            PlayerPrefs.SetInt("HighScore", Score);
        }
    }

    void AddTimerScore()
    {
        UpdateScoreBoard(ScorePerSecond);
        Invoke("AddTimerScore", SecondsBetweenScores);
    }
}
