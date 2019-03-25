using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotScript : MonoBehaviour
{
    public Vector3 startpoint;
    public Vector3 endpoint;
    public bool turning = false;
    public float movespeed = 10.0f;
    public float turnspeed = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        startpoint = transform.position;
        endpoint = startpoint + new Vector3(0, 0, 30);
    }

    // Update is called once per frame
    void Update()
    {
        if (turning)
        {
            if (transform.position.z >= endpoint.z)
                transform.LookAt(startpoint);
            else transform.LookAt(endpoint);
            Turned();
        }
        else
        {
            transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
            if (transform.position.z >= endpoint.z || transform.position.z <= startpoint.z)
                turning = true;
        }
    }

    protected void Turned()
    {
        print(transform.rotation.y);
        if (transform.rotation.y <= 0.01 && transform.rotation.y >= -0.01f)
            turning = false;
        else if ((transform.rotation.y >= 0.99f) || (transform.rotation.y <= -0.99f))
            turning = false;
    }

    public void Disable()
    {
        //disable robot
    }
}
