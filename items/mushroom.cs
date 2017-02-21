using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroom : MonoBehaviour {

	void OnTriggerEnter2D()
	{
		Destroy (this.gameObject);
		if (playerManager.playerState==0)
		{
			playerManager.playerState = 1;
		}
			
	}
}