using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private GameObject triggringNPC;
    private bool triggering;

    public GameObject npcText;

    private void Update()
    {
        if (triggering)
        {
            npcText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Interacting with NPC");// Make a menu for the NPC where you can buy buildings and make a way to prevent the counts of materials to go below 0 in the item pickup script.
                triggering = false;
            }
        }
        else
        {
            npcText.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "NPC")
        {
            triggringNPC = collider.gameObject;
            triggering = true;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "NPC")
        {
            triggringNPC = null;
            triggering = false;
        }
    }
}
