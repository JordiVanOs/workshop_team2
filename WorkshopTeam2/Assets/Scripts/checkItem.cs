using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkItem : MonoBehaviour
{
    public AudioSource thx;
    public AudioSource bad;
    bool missionComplete;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "koffie" && !missionComplete)
        {
           Debug.Log("Bedankt voor de heerlijke koffie");
            thx.Play();
            missionComplete = true;

            GameObject GO = GameObject.Find("Robot Main");
            if (GO != null)
                Destroy(GO.gameObject);
        }
        if(collision.gameObject.tag != "koffie" && !missionComplete)
        {
            Debug.Log("oprotten met die smerige rotzooi");
            bad.Play();
        }
    }
    
}
