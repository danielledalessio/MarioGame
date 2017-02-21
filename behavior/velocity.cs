using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocity : MonoBehaviour {

	public Vector2 velocity1 = Vector2.zero;

	private Rigidbody2D body2d;

	void Awake(){
		body2d = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate () {
		body2d.velocity = velocity1;
	}
}
