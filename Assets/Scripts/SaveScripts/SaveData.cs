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

<<<<<<< Updated upstream
// public class SaveItems
// {
// 	public int gear;
// 	public int nut;
// 	public int pipe;
// 	public int bolt;
// 	public int metalplate;

// 	public SaveItems(PickUpObject pickupObject)
// 	{
// 		gear = pickupObject.gear;
// 		nut = pickupObject.nut;
// 		pipe = pickupObject.pipe;
// 		bolt = pickupObject.bolt;
// 		metalplate = pickupObject.metalplate;

// 	}
// }
=======
public class SaveItems
{
	public int gear;
	public int pipe;
	public int metalplate;

	public SaveItems(PickUpObject pickupObject)
	{
		gear = pickupObject.gear;
		pipe = pickupObject.pipe;
		metalplate = pickupObject.metalplate;

	}
}
>>>>>>> Stashed changes

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

