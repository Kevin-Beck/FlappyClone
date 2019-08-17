using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunOnKeyPress : MonoBehaviour
{
    public GameEvent Run;
    public Canvas c;

    private void Update()
    {
        if(c.enabled && Input.anyKeyDown)
        {
            Run.Raise();
        }
    }
}
