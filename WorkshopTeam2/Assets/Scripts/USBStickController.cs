using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USBStickController : MonoBehaviour
{
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