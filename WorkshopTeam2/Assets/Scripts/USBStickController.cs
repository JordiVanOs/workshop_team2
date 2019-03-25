using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USBStickController : MonoBehaviour
{
    public Transform player;
    public bool pickedUp = false;


    void LateUpdate()
    {
        if (pickedUp)
        {
            transform.position = player.position + new Vector3(0, 0, 0.5f);
        }
    }

    public void Interact()
    {
        pickedUp = !pickedUp;
    }

    //Everything above can be removed when integrated with Player Controller!

    void OnCollisionEnter(Collision collision)
    {
        GameObject otherObject = collision.gameObject;
        if (otherObject.tag == "PC")
        {
            PCController controller = otherObject.GetComponent<PCController>();
            controller.ApplyUSBStick();
            Destroy(gameObject); //Remove this if u want to leave the USB-Stick in the scene! For example for animations or something.
        }
    }
}