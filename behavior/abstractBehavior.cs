using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class abstractBehavior : MonoBehaviour {

	public Buttons[] inputButtons;

	protected inputState inputState;
	protected Rigidbody2D body2D;
	protected collisionState collisionState;

	protected virtual void Awake(){
	
		inputState = GetComponent<inputState> ();
		body2D = GetComponent<Rigidbody2D> ();
		collisionState = GetComponent<collisionState> ();
	}
		
}
