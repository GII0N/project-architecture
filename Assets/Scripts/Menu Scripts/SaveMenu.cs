using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveMenu : MonoBehaviour
{
	public GameObject Savemenu;

	public PlayerMovement playerlocation;

	public float Continue;
	

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void CloseSave()
	{
		Savemenu.SetActive(false);
	}



	public void Savegame()
	{
		playerlocation.SaveLocationData();
		Continue = 1f;
	}
		
	public void Loadgame()
	{
		
		playerlocation.LoadLocationData();
	}
}
