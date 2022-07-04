using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private GameObject triggringNPC;
    private bool triggering;

    public GameObject npcText;
    public GameObject npcMenu;
    public GameObject InGameHud;

    private void Update()
    {
        if (triggering)
        {
            npcText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                npcMenu.SetActive(true);
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                triggering = false;
                InGameHud.SetActive(false);
            }
        }
        else
        {
            npcText.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
		{
            npcMenu.SetActive(false);
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
            InGameHud.SetActive(true);
		}
    }

    public void CloseMenu()
    {
        npcMenu.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        InGameHud.SetActive(true);
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
