using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameEvent EventWhenPickedUp;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            EventWhenPickedUp.Raise();
            SelfDestruct();
        }
    }

    private void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
