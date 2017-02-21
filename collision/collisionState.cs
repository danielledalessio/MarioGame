using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionState : MonoBehaviour {

	public LayerMask collisionLayer;
	public bool standing;
	public Vector2 bottomPosition = Vector2.zero;
	public float collisionRadius = 10f;
	public Color debugCollisionColor = Color.red;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
	
		var pos = bottomPosition;
		pos.x += transform.position.x;
		pos.y += transform.position.y;


		standing = Physics2D.OverlapCircle (pos, collisionRadius, collisionLayer);
	}

	void OnDrawGizmos()
	{
		Gizmos.color = debugCollisionColor;

		var pos = bottomPosition;
		pos.x += transform.position.x;
		pos.y += transform.position.y;

		Gizmos.DrawWireSphere (pos, collisionRadius);

		standing = Physics2D.OverlapCircle (pos, collisionRadius, collisionLayer);
	}
}
