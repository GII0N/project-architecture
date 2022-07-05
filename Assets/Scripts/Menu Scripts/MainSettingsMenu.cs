using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSettingsMenu : MonoBehaviour
{
	public bool Fullscreen;
	
	public Slider AudioVolumeSlider;

	public Toggle FullscreenActive;

	public AudioSource MainNoise;

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

	// Start is called before the first frame update
	void Start()
    {
		LoadSettingsData();
    }

    // Update is called once per frame
    void Update()
    {
		SaveSettingsData();
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

	public void ChangeAudioVolume()
	{
		MainNoise.volume = AudioVolumeSlider.value;
	}

	public void SaveSettingsData()
	{
		PlayerPrefs.SetFloat("Musicvolume", AudioVolumeSlider.value);
		PlayerPrefs.SetInt("Fullscreen", boolToInt(Fullscreen));

		FullscreenActive.isOn = Fullscreen;

	}

	public void LoadSettingsData()
	{
		AudioVolumeSlider.value = PlayerPrefs.GetFloat("Musicvolume");
		Fullscreen = intToBool(PlayerPrefs.GetInt("Fullscreen"));

		FullscreenActive.isOn = Fullscreen;
	}
}
