using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCController : MonoBehaviour
{
    public GameObject robot = null;

    void Start()
    {
        if (robot == null)
        {
            Debug.Log("Warning!: No Robot assigned!");
        }
    }

    public void ApplyUSBStick()
    {
        Debug.Log("Good Job!");
        if (robot != null)
        {
            // if (robot is GameObject) 
            // {
            //     robot.Disable();
            // }
        }
    }
}