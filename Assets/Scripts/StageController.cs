using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageController : MonoBehaviour
{
    public Canvas Rules;
    public Canvas Run;
    public Canvas GameOver;

    // Start is called before the first frame update
    void Start()
    {
        GameOver.enabled = false;
        Rules.enabled = true;
        Time.timeScale = 0;
    }

    public void EnableGameOver()
    {
        Time.timeScale = 0;
        GameOver.enabled = true;
    }

    public void RunScene()
    {
        Rules.enabled = false;
        Run.enabled = true;
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
