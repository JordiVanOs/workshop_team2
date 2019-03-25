using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MockPlayerScript : MonoBehaviour
{
    private float useObjectTimer = 0;
    private readonly float cooldown = .3f;
    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit;

        useObjectTimer += Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            if (useObjectTimer > cooldown)
            {
                useObjectTimer = 0;
                if (Physics.Raycast(ray, out Hit))
                {
                    if (Hit.collider.CompareTag("Button"))
                    {
                        float distance = Vector3.Distance(transform.position, Hit.collider.transform.position);
                        if (distance < 3)
                            Hit.collider.gameObject.GetComponent<ChooseDrink>().SpawnDrink();
                    }
                }
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-transform.forward * Time.deltaTime * 5);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * Time.deltaTime * 5);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.up * Time.deltaTime * 5);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.down * Time.deltaTime * 5);
        }
    }
}
