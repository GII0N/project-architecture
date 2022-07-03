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
	public Slider AudioVolumeSlider;
	
	public bool Fullscreen;
	public bool activecrosshair;
	
	public AudioSource MainNoise;
	


	public void Start()
	{
		
	}

	void Update()
	{	
		ChangeBrigthness();
		ChangeAudioVolume();

		CrossHair.SetActive(activecrosshair);
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

	public void ChangeBrigthness()
	{
		SceneLight.intensity = BrigtnesSlider.value;
	}

	public void ChangeAudioVolume()
	{
		MainNoise.volume = AudioVolumeSlider.value;
	}
	
	public void SaveSettingsData()
	{
		SaveSystem.SaveSettings(this);
	}

	public void LoadSettingsData()
	{
		SaveSystem.LoadSettings();
	}
}
