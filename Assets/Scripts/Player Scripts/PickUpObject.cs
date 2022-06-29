using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUpObject : MonoBehaviour
{
    public int gear;
    public int nut;
    public int pipe;
	public int bolt;
	public int metalplate;
	public TextMeshProUGUI gearCounter;
    public TextMeshProUGUI nutCounter;
    public TextMeshProUGUI pipeCounter;
	public TextMeshProUGUI boltCounter;
	public TextMeshProUGUI metalplateCounter;

	private void OnTriggerEnter(Collider collider)
    {
        //prevent it from being below zero when buying stuff
        if (collider.transform.tag == "Gear")
        {
            gear++;
            gearCounter.text = gear.ToString();
            Destroy(collider.gameObject);
        }
        if (collider.transform.tag == "Nut")
        {
            nut++;
            nutCounter.text = nut.ToString();
            Destroy(collider.gameObject);
        }
		if (collider.transform.tag == "bolt")
		{
			bolt++;
			boltCounter.text = bolt.ToString();
			Destroy(collider.gameObject);
		}
		if (collider.transform.tag == "Pipe")
		{
			pipe++;
			pipeCounter.text = pipe.ToString();
			Destroy(collider.gameObject);
		}
		if (collider.transform.tag == "Metalplate")
        {
            metalplate++;
            metalplateCounter.text = metalplate.ToString();
            Destroy(collider.gameObject);
        }
    }
}