using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class SettingsMenu : MonoBehaviour
{
	public GameObject CrossHair;
	public bool Active = true;
	public GameObject Settingsmenu;
	public Light SceneLight;
	public Slider BrigtnesSlider;
	void Update()
	{
		Crosshair();
		CrossHair.SetActive(Active);
		SceneLight.intensity = BrigtnesSlider.value;
	}
   public void Crosshair()
	{
		if (Active == true)
		{
			Active = false;
		}
		else
		{
			Active = true;
		}
	}
	public void CloseMenu()
	{
		Settingsmenu.SetActive(false);
	}
	public void ToggleFullscreen(bool isFullScreen)
	{
		Screen.fullScreen = isFullScreen;
	}


}
