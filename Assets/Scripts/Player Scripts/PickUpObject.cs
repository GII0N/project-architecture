using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUpObject : MonoBehaviour
{
    public int wood;
    public int stone;
    public int metal;

    public GameObject NotEnoughError;
    public GameObject Building1;
    public GameObject Building2;
    public GameObject Building3;
    public GameObject Building4;
    public GameObject Building5;
    public GameObject Building6;
    public GameObject Building7;
    public GameObject Building8;
    public GameObject Building9;

    public TextMeshProUGUI woodCounter;
    public TextMeshProUGUI woodCounter1;
    public TextMeshProUGUI stoneCounter;
    public TextMeshProUGUI stoneCounter1;
    public TextMeshProUGUI metalCounter;
    public TextMeshProUGUI metalCounter1;

    private void OnTriggerEnter(Collider collider)
    {
        //prevent it from being below zero when buying stuff
        if (collider.transform.tag == "Wood")
        {
            wood++;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            Destroy(collider.gameObject);
        }
        if (collider.transform.tag == "Stone")
        {
            stone++;
            stoneCounter.text = stone.ToString();
            stoneCounter1.text = stone.ToString();
            Destroy(collider.gameObject);
        }
        if (collider.transform.tag == "Metal")
        {
            metal++;
            metalCounter.text = metal.ToString();
            metalCounter1.text = metal.ToString();
            Destroy(collider.gameObject);
        }
    }

    public void BuyItem1()
    {
        if (wood >= 2)
        {
            wood -= 2;
            woodCounter.text = wood.ToString();
            woodCounter1.text = wood.ToString();
            Building1.SetActive(true);
        }
        else
        {
            NotEnoughError.SetActive(true);
        }
    }
}