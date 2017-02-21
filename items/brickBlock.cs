using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickBlock : MonoBehaviour {

	public GameObject spawnPoint;
	public GameObject coinprefab;
	public int coinCount = 2;

	IEnumerator OnTriggerEnter2D()
	{
		if(coinCount != 0)
		{
			Object coin = Instantiate(coinprefab, spawnPoint.transform.position, spawnPoint.transform.rotation);

			yield return new WaitForSeconds(.25f);

			Destroy(coin);
			coinCount--;
			scoremanager.score += Coin.coinValue;
		}

		if(coinCount == 0)
		{
			print("You're breaking me... ");
		}
	}

}
