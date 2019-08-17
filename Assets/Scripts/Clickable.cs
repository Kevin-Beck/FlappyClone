using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    public GameEvent EventWhenClicked;
    // Start is called before the first frame update
    
    private void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider.gameObject == this.gameObject)
                {
                    EventWhenClicked.Raise();
                    SelfDestruct();
                }
            }
        }
    }
    private void FixedUpdate()
    {
        transform.Rotate(1,1,1);
    }

    private void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
