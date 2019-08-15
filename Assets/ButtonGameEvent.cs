using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGameEvent : MonoBehaviour
{
    public GameEvent ge;

    public void RaiseEvent()
    {
        ge.Raise();
    }
}
