using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenController : MonoBehaviour
{
    private Material BackgroundColor;   //The material to change the color of
    private Renderer screenRenderer;    //The renderer to get the material from
    public GameObject robot;
    public buttonController ButtonController;

    void Start()
    {
        screenRenderer = GetComponentInChildren<Renderer>();
        BackgroundColor = screenRenderer.material;

        //Start out as blue
        BackgroundColor.color = Color.blue;
    }

    void Update()
    {
        if (ButtonController.buttonA == true)
        {
            ShowCorrect();
            //ButtonController.buttonA = false;
            //robot.Disable();
        }
        else if (ButtonController.buttonB == true)
        {
            ShowWrong();
            ButtonController.buttonB = false;
        }
        else if (ButtonController.buttonC == true)
        {
            ShowWrong();
            ButtonController.buttonB = false;
        }
    }

    public void ShowCorrect()
    {
        BackgroundColor.color = Color.green;
    }

    public void ShowWrong()
    {
        BackgroundColor.color = Color.red;
    }
}
