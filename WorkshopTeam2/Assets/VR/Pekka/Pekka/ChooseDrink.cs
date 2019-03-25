using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Valve.VR.InteractionSystem.Sample
{
    public class ChooseDrink : MonoBehaviour
    {
        public HoverButton hoverButton;
        public GameObject drinkSpawnPoint;
        public DrinkChoices drinkChoices;
        public GameObject drinkPrefab;

        private void Start()
        {
            hoverButton.onButtonDown.AddListener(OnButtonDown);
        }

        private void OnButtonDown(Hand hand)
        {
            StartCoroutine(SpawnDrink());
        }

        public IEnumerator SpawnDrink()
        {
            Debug.Log("SpawnObject");
            Instantiate(drinkPrefab, drinkSpawnPoint.transform.position, drinkSpawnPoint.transform.rotation);
            yield return null;
        }
    }
}
