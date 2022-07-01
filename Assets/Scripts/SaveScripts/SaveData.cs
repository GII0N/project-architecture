using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class SavePlayerLocation
{

	public float[] position;

	public SavePlayerLocation(PlayerMovement playerMovement)
	{
		position = new float[3];
		position[0] = playerMovement.transform.position.x;
		position[1] = playerMovement.transform.position.y;
		position[2] = playerMovement.transform.position.z;
	}
}

public class SaveItems
{
	public int gear;
	public int pipe;
	public int metalplate;

	public SaveItems(PickUpObject pickupObject)
	{
		gear = pickupObject.wood;
		pipe = pickupObject.stone;
		metalplate = pickupObject.metal;

	}
}

public class SaveSettings
{
	public bool crosshair;
	public bool fullscreen;
	public Slider brightness;
	public Slider audiovolume;
	public Slider sensitivity;

	public SaveSettings(SettingsMenu settingsMenu)
	{

		crosshair = settingsMenu.activecrosshair;
		fullscreen = settingsMenu.Fullscreen;
		brightness.value = settingsMenu.BrigtnesSlider.value;
		sensitivity = settingsMenu.SensitivitySlider;
		audiovolume = settingsMenu.audiovolume;

	}
}

