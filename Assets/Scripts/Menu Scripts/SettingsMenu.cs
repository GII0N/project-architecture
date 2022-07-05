using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class SettingsMenu : MonoBehaviour
{
	public GameObject CrossHair;
	public GameObject Settingsmenu;
	

	public Slider SensitivitySlider;
	
	public bool Fullscreen;
	public bool activecrosshair;


	public Toggle CrosshairActive;
	public Toggle FullscreenActive;

	int boolToInt(bool val)
	{
		if (val)
			return 1;
		else
			return 0;
	}

	bool intToBool(int val)
	{
		if (val != 0)
			return true;
		else
			return false;
	}

	void Awake()
	{
		LoadSettingsData();

		SaveSettingsData();

		if (Fullscreen == false)
		{
			Screen.fullScreenMode = FullScreenMode.Windowed;
		}
		else
		{
			Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
		}
	}

	void Update()
	{	

		SaveSettingsData();

		CrossHair.SetActive(activecrosshair);

		if (Fullscreen == false)
		{
			Screen.fullScreenMode = FullScreenMode.Windowed;
		}
		else
		{
			Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
		}
	}

	public void CloseMenu()
	{
		Settingsmenu.SetActive(false);
		SaveSettingsData();
		
		if(Fullscreen == false)
		{
			Screen.fullScreenMode = FullScreenMode.Windowed;
		}
		else
		{
			Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
		}
	}

	public void Crosshair()
	{
		
		if (activecrosshair == true)
		{
			activecrosshair = false;
		}
		else
		{
			activecrosshair = true;
		}

	}

	public void ToggleFullscreen()
	{

		if (Fullscreen == true)
		{
			Fullscreen = false;
			Screen.fullScreenMode = FullScreenMode.Windowed;
		}
		else
		{
			Fullscreen = true;
			Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
		}

	}

	
	public void SaveSettingsData()
	{
		PlayerPrefs.SetFloat("Sensitivity", SensitivitySlider.value);
		PlayerPrefs.SetInt("Crosshair", boolToInt(activecrosshair));
		PlayerPrefs.SetInt("Fullscreen", boolToInt(Fullscreen));

		CrosshairActive.isOn = activecrosshair;
		FullscreenActive.isOn = Fullscreen;

	}

	public void LoadSettingsData()
	{
		SensitivitySlider.value = PlayerPrefs.GetFloat("Sensitivity");
		activecrosshair = intToBool(PlayerPrefs.GetInt("Crosshair"));
		Fullscreen = intToBool(PlayerPrefs.GetInt("Fullscreen"));

		CrosshairActive.isOn = activecrosshair;
		FullscreenActive.isOn = Fullscreen;
		
		CrossHair.SetActive(activecrosshair);
	}


}
