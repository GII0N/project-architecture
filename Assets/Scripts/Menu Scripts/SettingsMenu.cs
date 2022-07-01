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
	public Slider audiovolume;
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
		}
		else
		{
			Fullscreen = true;
		}
		
	}

	public void GetSettings()
	{
		Fullscreen= Screen.fullScreen;
		
	}

	public void UpdateSettings()
	{
		
	}
}
