using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu: MonoBehaviour
{
    public GameObject Start;
    public GameObject Options;
    public GameObject Credits;

	public PlayerMovement PlayerLocation;

	private Scene Game;

    public void ContinueGame()
    {
		//to-do: Make a save file and load that in if you press continue game
		//to-do: Disable this button if theres no save game found
		//Settings.LoadSettingsData();
		//PlayerLocation.LoadLocationData();
		//Game = GameObject.Find("Game").GetComponent<Options>();
		Debug.Log("Cgame");
	}

    public void StartNewGame()
    {  
        SceneManager.LoadScene("Game");
		//to-do: Add a popup that asks if you are sure about starting a new game & reset/delete the old savegame if you press yes
	}

    public void OpenOptions()
    {
        if (Options != null)
        {
            Options.SetActive(true);
            Start.SetActive(false);
        }
    }

    public void CloseOptions()
    {
        if (Start != null)
        {
            Options.SetActive(false);
            Start.SetActive(true);
        }
    }

    public void OpenCredits()
    {
        if (Credits != null)
        {
            Credits.SetActive(true);
            Start.SetActive(false);
        }
    }

    public void CloseCredits()
    {
        if (Start != null)
        {
            Credits.SetActive(false);
            Start.SetActive(true);
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

	public void ToggleFullscreen(bool isFullScreen)
	{
		Screen.fullScreen = isFullScreen;
		
	}

}
