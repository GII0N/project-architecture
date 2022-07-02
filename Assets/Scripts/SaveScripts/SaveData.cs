using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PlayerLocationData
{

	public float[] position;

	public PlayerLocationData(PlayerMovement playerMovement)
	{
		position = new float[3];
		position[0] = playerMovement.transform.position.x;
		position[1] = playerMovement.transform.position.y;
		position[2] = playerMovement.transform.position.z;
	}
}

public class SaveItems
{
	public int wood;
	public int stone;
	public int metal;

	public SaveItems(PickUpObject pickupObject)
	{
		wood = pickupObject.wood;
		stone = pickupObject.stone;
		metal = pickupObject.metal;

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
		audiovolume = settingsMenu.audiovolumeslider;

	}
}

