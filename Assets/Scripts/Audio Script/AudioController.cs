using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
	private AudioSource MainAudio;
	public GameObject MusicObject;
	private float MusicVolume = 1f;
	public Slider AudioVolumeSlider;


	private void Start()
	{

		MusicObject = GameObject.FindWithTag("MainMusic");
		MainAudio = MusicObject.GetComponent<AudioSource>();

		MusicVolume = PlayerPrefs.GetFloat("volume");
		MainAudio.volume = MusicVolume;
		AudioVolumeSlider.value = MusicVolume;

	}

	private void Update()
	{
		VolumeUpdater();
		MainAudio.volume = MusicVolume;
		PlayerPrefs.SetFloat("volume", MusicVolume);
	}

	public void VolumeUpdater()
	{
		MusicVolume = AudioVolumeSlider.value;
	}
}
