using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMoveForce : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] float Force;
    [SerializeField] GameEvent MoveEvent;
    [SerializeField] string Key;
    [SerializeField] Vector3 Direction;
    public bool AddForceOnStart = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (AddForceOnStart)
            AddForce();
    }

    private void Update()
    {
        if (Input.GetKeyDown(Key) && Time.timeScale > 0)
        {
            AddForce();
        }
    }

    public void AddForce()
    {
        rb.AddForce(Direction*Force);
        MoveEvent.Raise();
    }

}
