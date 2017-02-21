using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
	public static int coinValue = 200;
	public static int coinCount = 1;
	void OnTriggerEnter2D()
	{
		scoremanager.score += coinValue;
		coinmanager.coins += coinCount;
		Destroy(gameObject);
	}
}
