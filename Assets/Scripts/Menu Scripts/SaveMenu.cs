using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveMenu : MonoBehaviour
{
	public GameObject Savemenu;
	public GameObject SaveGame;
	public GameObject LoadGame;
	public GameObject NewGame;
	

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

	public void OpenSave()
	{
		SaveGame.SetActive(true);
	}

	public void OpenLoad()
	{
		LoadGame.SetActive(true);
	}

	public void OpenNewGame()
	{
		NewGame.SetActive(true);
	}

	public void SaveData()
	{
		//SaveSystem.SaveLocation(playerMovement);
	}
		

}
