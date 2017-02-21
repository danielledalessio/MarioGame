using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireflower : MonoBehaviour {

	void OnTriggerEnter2D()
	{
		playerManager.playerState = 2;
		Destroy (this.gameObject);

	}
}