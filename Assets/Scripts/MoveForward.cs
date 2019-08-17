using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveForward : MonoBehaviour
{

    [SerializeField] public float ForwardSpeed;
    Rigidbody rb;
    public float forwardInc;
    public float forwardDec;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        InitiateMovement();
    }

    public void SetSpeed(float NewSpeed)
    {
        ForwardSpeed = NewSpeed;
        InitiateMovement();
    }
    public void IncSpeed()
    {
        ForwardSpeed += forwardInc;
        InitiateMovement();
    }
    public void DecSpeed()
    {
        ForwardSpeed -= forwardDec;
        if(ForwardSpeed  < .1f)
        {
            ForwardSpeed = .1f;
        }
        InitiateMovement();
    }

    private void InitiateMovement()
    {
        rb.velocity = new Vector3(ForwardSpeed, 0, 0);
    }
}
