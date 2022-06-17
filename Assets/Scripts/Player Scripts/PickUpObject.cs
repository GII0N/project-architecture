using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUpObject : MonoBehaviour
{
    public int wood;
    public int stone;
    public int metal;
    public TextMeshProUGUI woodCounter;
    public TextMeshProUGUI stoneCounter;
    public TextMeshProUGUI metalCounter;

    private void OnTriggerEnter(Collider collider)
    {
        //prevent it from being below zero when buying stuff
        if (collider.transform.tag == "Wood")
        {
            wood++;
            woodCounter.text = wood.ToString();
            Destroy(collider.gameObject);
        }
        if (collider.transform.tag == "Stone")
        {
            stone++;
            stoneCounter.text = stone.ToString();
            Destroy(collider.gameObject);
        }
        if (collider.transform.tag == "Metal")
        {
            metal++;
            metalCounter.text = metal.ToString();
            Destroy(collider.gameObject);
        }
    }
}