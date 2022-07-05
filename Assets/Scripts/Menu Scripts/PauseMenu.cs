using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
	public GameObject InGameHud;
	public GameObject Pausemenu;
	public GameObject ExitMenu;
	public GameObject SettingsMenu;
	public GameObject SaveMenu;
	public float progress = 0;
	public Slider ProgressSlider;
	public SettingsMenu settings;

	private void Start()
	{
		Time.timeScale = 1f;

		settings.LoadSettingsData();	
	}
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (Time.timeScale == 0f)
			{
				Resume();
			}
			else
			{
				Pause();
			}
		}

		if (Time.timeScale == 1f)
		{
			UpdateProgress();
		}
	}
	public void Resume()
	{
		InGameHud.SetActive(true);
		Pausemenu.SetActive(false);
		Time.timeScale = 1f;
		Cursor.lockState = CursorLockMode.Locked;
		ExitMenu.SetActive(false);
		SettingsMenu.SetActive(false);
		SaveMenu.SetActive(false);

	}

	void Pause()
	{
		InGameHud.SetActive(false);
		Pausemenu.SetActive(true);
		Time.timeScale = 0f;
		Cursor.lockState = CursorLockMode.None;
		
	}

	public void ExitGame()
	{
		ExitMenu.SetActive(true);
	}

	public void ConfirmExit()
	{
		SceneManager.LoadScene("MainMenu");
	}
	public void CancelExit()
	{
		ExitMenu.SetActive(false);
	}

	public void OpenSettings()
	{
		SettingsMenu.SetActive(true);
	}

		public void CloseSettings()
	{
		SettingsMenu.SetActive(false);
	}

	public void OpenSaveMenu()
	{
		SaveMenu.SetActive(true);
	}

	public void UpdateProgress()
	{
		progress++;
		ProgressSlider.value = progress;
	}
}
