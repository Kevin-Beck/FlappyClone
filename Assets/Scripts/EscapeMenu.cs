using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeMenu : MonoBehaviour
{
    public GameEvent EscapeKey;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EscapeKey.Raise();
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}