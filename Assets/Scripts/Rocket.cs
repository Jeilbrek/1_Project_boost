using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetButton("Jump"))
        {
            rigidbody.AddRelativeForce(Vector3.up);
        }

        if(Input.GetAxis("Horizontal") > 0)
        {
            print("Rotating to the right");
        } 
        else if(Input.GetAxis("Horizontal") < 0)
        {
            print("Rotating to the left");
        }
    }
}
