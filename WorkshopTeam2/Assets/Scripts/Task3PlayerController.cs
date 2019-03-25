using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3PlayerController : MonoBehaviour
{
    public float moveSpeed = 7;
    public float turnSpeed = 100;

    void Update()
    {
        //Move forward
        if (Input.GetKey(KeyCode.W))
        {
            Move(1);
        }
        //Move backwards
        else if (Input.GetKey(KeyCode.S))
        {
            Move(-1);
        }
        //Turn Left
        else if (Input.GetKey(KeyCode.A))
        {
            Turn(-1);
        }
        //Turn Right
        else if (Input.GetKey(KeyCode.D))
        {
            Turn(1);
        }
    }

    //Move towards a direction: Positive is Forward, Negative is Backward
    private void Move(int direction)
    {
        transform.Translate(direction * Vector3.forward * moveSpeed * Time.deltaTime);
    }

    //Turn towards a direction: Positive is Right, Negative is Left
    private void Turn(int direction)
    {
        transform.Rotate(Vector3.up * direction * turnSpeed * Time.deltaTime);
    }
}