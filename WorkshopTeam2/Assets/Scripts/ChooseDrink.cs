using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChooseDrink : MonoBehaviour
{
    public GameObject drinkSpawnPoint;
    public DrinkChoices drinkChoices;
    public GameObject drinkPrefab;

    public void SpawnDrink()
    {
        Debug.Log("SpawnObject");
        Instantiate(drinkPrefab, drinkSpawnPoint.transform.position, drinkSpawnPoint.transform.rotation);
    }
}
