using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private GameObject triggringNPC;
    private bool triggering;

    public GameObject npcText;
    public GameObject npcMenu;

    private void Update()
    {
        if (triggering)
        {
            npcText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                npcMenu.SetActive(true);
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
