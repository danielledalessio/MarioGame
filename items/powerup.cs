using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour {

	public GameObject fireflower;
	public GameObject mushroom;
	public GameObject spawn;
	void OnTriggerEnter2D()
	{
		if(equip._currentItem == 0)
		{
			Instantiate(mushroom, spawn.transform.position, Quaternion.identity);               
		}
		else if(equip._currentItem >=1)
		{
			Instantiate(fireflower, spawn.transform.position, Quaternion.identity);
		}

		Destroy(this);
		print("Everybody gets one");

	}
}

