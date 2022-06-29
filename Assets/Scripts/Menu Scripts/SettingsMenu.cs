using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class SettingsMenu : MonoBehaviour
{
	public GameObject CrossHair;
	public GameObject Settingsmenu;
	public Light SceneLight;
	public Slider BrigtnesSlider;
	public Slider SensitivitySlider;
	public bool Fullscreen;
	public bool activecrosshair;

	public void Start()
	{
		GetSettings(); 
	}

	void Update()
	{
		UpdateSettings();
	}

	public void CloseMenu()
	{
		Settingsmenu.SetActive(false);

	}

	public void Crosshair()
	{
		
		if (SettingBetweenScenes.Active == true)
		{
			SettingBetweenScenes.Active = false;
		}
		else
		{
			SettingBetweenScenes.Active = true;
		}
	}

	public void ToggleFullscreen()
	{

		if (SettingBetweenScenes.FullScreen == true)
		{
			SettingBetweenScenes.FullScreen = false;
		}
		else
		{
			SettingBetweenScenes.FullScreen = true;
		}
		
	}

	public void GetSettings()
	{
		SettingBetweenScenes.FullScreen = Screen.fullScreen;
		BrigtnesSlider.value = SettingBetweenScenes.Scenelight.value;
	}

	public void UpdateSettings()
	{
		Screen.fullScreen = SettingBetweenScenes.FullScreen;
		CrossHair.SetActive(SettingBetweenScenes.Active);
		SettingBetweenScenes.Scenelight.value = BrigtnesSlider.value;
		SettingBetweenScenes.MouseSensitivity.value = SensitivitySlider.value;
	}
}
