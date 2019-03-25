using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1Controller : MonoBehaviour
{
    public GameObject robot;                    //The robot to disable
    //ButtonPress ButtonController;       //Checks which button is pressed
    private ScreenController ScreenController;  //Updates the screencolor

    void Start()
    {
        //ButtonController = GetComponentInChildren<ButtonPress>();
        ScreenController = GetComponentInChildren<ScreenController>();
    }

    void Update()
    {
        /*
        switch(ButtonController.buttonABC)
        {
            case 0:
                //nothing pressed, so do nothing
                break;
            case 1:
                //wrong answer
                ScreenController.ShowWrong();
                break;
            case 2:
                //wrong answer
                ScreenController.ShowWrong();
                break;
            case 3:
                //right answer
                ScreenController.ShowCorrect();
                robot.Disable();
                break;
        }
        */
    }
}
