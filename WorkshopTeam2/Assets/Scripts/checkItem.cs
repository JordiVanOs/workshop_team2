using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkItem : MonoBehaviour
{
    public AudioSource thx;
    public AudioSource bad;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "koffie")
        {
           Debug.Log("Bedankt voor de heerlijke koffie");
            thx.Play();
        }
        if(collision.gameObject.tag != "koffie")
        {
            Debug.Log("oprotten met die smerige rotzooi");
            bad.Play();
        }
    }
    

     void Start()
    {
        
    }
    void Update()
    {
        
    }
}
