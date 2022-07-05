using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveMenu : MonoBehaviour
{
	public GameObject Savemenu;

	public PlayerMovement playerlocation;
	

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void CloseSave()
	{
		Savemenu.SetActive(false);
	}

	public void NewGame()
	{

	}

	public void Savegame()
	{
		playerlocation.SaveLocationData();
	}
		
	public void Loadgame()
	{

		playerlocation.LoadLocationData();
	}
}
