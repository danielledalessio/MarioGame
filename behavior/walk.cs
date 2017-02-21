using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : abstractBehavior{

	public float speed = 50;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		var right = inputState.GetButtonValue (inputButtons [0]);
		var left = inputState.GetButtonValue (inputButtons [1]);

		if (right || left) {
			var tmpSpeed = speed;
			var velX = tmpSpeed * (float)inputState.direction;
			body2D.velocity = new Vector2 (velX, body2D.velocity.y);
		}

	}
}
