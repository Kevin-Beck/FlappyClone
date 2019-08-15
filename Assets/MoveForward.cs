using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveForward : MonoBehaviour
{

    [SerializeField] public float ForwardSpeed;
    Rigidbody rb;
    public float forwardInc;

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

    private void InitiateMovement()
    {
        rb.velocity = new Vector3(ForwardSpeed, 0, 0);
    }
}
