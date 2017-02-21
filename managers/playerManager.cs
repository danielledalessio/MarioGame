 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour {

	private inputState inputState;
	private walk walkBehavior;
	private Animator animator;
	private collisionState collisionState;
	public static int playerState;
	public Color baseColor;
	public Color fireColor;
	public duck duckBehavior;

	void Awake(){
		inputState = GetComponent<inputState> ();
		walkBehavior = GetComponent<walk> ();
		animator = GetComponent<Animator> ();
		collisionState = GetComponent<collisionState> ();
		duckBehavior = GetComponent<duck> ();
	}

	// Use this for initialization
	void Start () {
		playerState = 0;
	}
		

	// Update is called once per frame
	void Update () {
		if (collisionState.standing) {
			ChangeAnimationState (0);
		}
		if (inputState.absVelX > 1) {
			ChangeAnimationState (1);
		}
		if (inputState.absVelY > 1) {
			ChangeAnimationState (2);
		}
		if (duckBehavior.ducking) {
			ChangeAnimationState (3);
		}
	}
		

	void ChangeAnimationState (int value){
		animator.SetInteger ("AnimState", value);
	}

}
