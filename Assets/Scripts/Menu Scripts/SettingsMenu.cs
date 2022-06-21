using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
	public GameObject CrossHair;
	public bool Active = true;

	void Update()
	{
		Crosshair();
		CrossHair.SetActive(Active);
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
}
