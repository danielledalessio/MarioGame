using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinmanager : MonoBehaviour {

	Text text;

	public static int coins;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		coins = 0;
	}

	// Update is called once per frame
	void Update () {
		text.text = "Coins: " + coins;
	}
}
