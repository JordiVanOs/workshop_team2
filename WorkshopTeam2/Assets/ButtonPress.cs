using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Threading.Tasks;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;
using UnityEngine.Events;

public class ButtonPress : MonoBehaviour
{
    public GameObject definedButton;
    public UnityEvent OnClick = new UnityEvent();
    public int buttonABC; //1 = a , 2 = b, 3 = c
    private bool buttonPressed = false;
    public float pressedDownTime;
    private bool timerEnd = false;
    

    // Use this for initialization
    void Start()
    {
        definedButton = this.gameObject;

        OnClick.AddListener(pressing);
    }



    void pressing()
    {
        buttonPressed = true;

        if (buttonABC == 3)
        {
            
            Debug.Log("Answer Correct: " + buttonABC + " is clicked");
        }
        else
        {
            Debug.Log("False: " + buttonABC + " is clicked");
        }

        buttonPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit;

    
        if (Input.GetMouseButtonDown(0))
        {
            pressedDownTime -= Time.deltaTime;
            if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject && buttonPressed == false)
            {
                
                transform.position = new Vector3(transform.position.x, 1.05f, transform.position.z);
                OnClick.Invoke();
                
                timerEnd = true;
               
            }
        }

        if (timerEnd)
        {
            pressedDownTime -= Time.deltaTime;
            if (pressedDownTime <= 0.0f)
            {
                transform.position = new Vector3(transform.position.x, 1.1f, transform.position.z);
                pressedDownTime = 1.0f;
                timerEnd = false;
            }
        }


    }
}
