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

	public void Start()
	{
		ChangeAudioVolume();
		ChangeBrigthness();
		LoadSettingsData();
	}

	void Update()
	{	
		ChangeBrigthness();
		ChangeAudioVolume();
		SaveSettingsData();

		CrossHair.SetActive(activecrosshair);
	}

	public void CloseMenu()
	{
		Settingsmenu.SetActive(false);
		SaveSettingsData();

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
		if (!BrigtnesSlider) 
		{
			SceneLight.intensity = 1f;
		}
		else
		SceneLight.intensity = BrigtnesSlider.value;
	}

	public void ChangeAudioVolume()
	{
		MainNoise.volume = AudioVolumeSlider.value;
	}
	
	public void SaveSettingsData()
	{
		PlayerPrefs.SetFloat("Musicvolume", AudioVolumeSlider.value);
		PlayerPrefs.SetFloat("Brightness", BrigtnesSlider.value);
		PlayerPrefs.SetFloat("Sensitivity", SensitivitySlider.value);
		PlayerPrefs.SetInt("Crosshair", boolToInt(activecrosshair));
		PlayerPrefs.SetInt("Fullscreen", boolToInt(Fullscreen));

		CrosshairActive.isOn = activecrosshair;
		FullscreenActive.isOn = Fullscreen;

	}

	public void LoadSettingsData()
	{
		AudioVolumeSlider.value = PlayerPrefs.GetFloat("Musicvolume");
		BrigtnesSlider.value = PlayerPrefs.GetFloat("Brightness");
		SensitivitySlider.value = PlayerPrefs.GetFloat("Sensitivity");
		activecrosshair = intToBool(PlayerPrefs.GetInt("Crosshair"));
		Fullscreen = intToBool(PlayerPrefs.GetInt("Fullscreen"));

		CrosshairActive.isOn = activecrosshair;
		FullscreenActive.isOn = Fullscreen;
		
		CrossHair.SetActive(activecrosshair);
	}
}
