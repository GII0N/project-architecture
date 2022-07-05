using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSettingsMenu : MonoBehaviour
{
	public bool Fullscreen;
	
	public Slider AudioVolumeSlider;

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

	private void Awake()
	{
		LoadSettingsData();
	}
	// Start is called before the first frame update
	void Start()
    {
		LoadSettingsData();
		
		if (Fullscreen == false)
		{
			Screen.fullScreenMode = FullScreenMode.Windowed;
		}
		else
		{
			Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
		}
		SaveSettingsData();
	}

    // Update is called once per frame
    void Update()
    {
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
		PlayerPrefs.SetInt("Fullscreen", boolToInt(Fullscreen));

		FullscreenActive.isOn = Fullscreen;

	}

	public void LoadSettingsData()
	{
		Fullscreen = intToBool(PlayerPrefs.GetInt("Fullscreen"));

		FullscreenActive.isOn = Fullscreen;
	}
}
