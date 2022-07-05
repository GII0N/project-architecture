using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroyAudio : MonoBehaviour
{
	private void Awake()
	{
		GameObject[] musicobject = GameObject.FindGameObjectsWithTag("MainMusic");
		
		if(musicobject.Length > 1)
		{
			Destroy(this.gameObject);
		}
		DontDestroyOnLoad(this.gameObject);
	}
}
