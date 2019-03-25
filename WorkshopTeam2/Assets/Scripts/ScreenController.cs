using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenController : MonoBehaviour
{
    private Material BackgroundColor;   //The material to change the color of
    private Renderer screenRenderer;    //The renderer to get the material from

    void Start()
    {
        screenRenderer = GetComponentInChildren<Renderer>();
        BackgroundColor = screenRenderer.material;

        //Start out as blue
        BackgroundColor.color = Color.blue;
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
