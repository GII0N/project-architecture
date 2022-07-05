using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuickLoad : MonoBehaviour
{
	
	public Light SceneLight;
	public Slider BrigtnesSlider;

	private void Awake()
	{
		
		BrigtnesSlider.value = PlayerPrefs.GetFloat("Brightness");
		ChangeBrigthness();

	}

	private void Start()
	{
		BrigtnesSlider.value = PlayerPrefs.GetFloat("Brightness");
		ChangeBrigthness();
	}

	private void Update()
	{
		PlayerPrefs.SetFloat("Brightness", BrigtnesSlider.value);
		ChangeBrigthness();
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
}