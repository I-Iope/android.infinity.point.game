using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMoviment : MonoBehaviour {

	public float speed;
	public float jumpForce;
	public bool onFloor;
	public float radius;

	public Vector2 florColliionPoint;
	public LayerMask platform;

	private Rigidbody2D rb2D;

	private float horizontal;

	void Start () {
		rb2D = GetComponent<Rigidbody2D> ();
	}
	
	void Update () {
		horizontal = CrossPlatformInputManager.GetAxis ("Horizontal");
		IsOnFloor ();
		InputControl ();
		ChangeDirection (horizontal);
		Moviment (horizontal);
	}

	private void OnDrawGizmos () {
		var positionPoint = florColliionPoint;
		positionPoint.x += transform.position.x;
		positionPoint.y += transform.position.y;

		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (positionPoint, radius);
	} 

	private void IsOnFloor () {
		var positionPoint = florColliionPoint;
		positionPoint.x += transform.position.x;
		positionPoint.y += transform.position.y;

		onFloor = Physics2D.OverlapCircle (positionPoint, radius, platform);
	}

	private void Moviment (float horiz) {
		rb2D.velocity = new Vector2 ((horiz * speed), rb2D.velocity.y);
	}

	private void ChangeDirection (float horiz) {
		if (horiz < 0) {
			transform.rotation = new Quaternion (0, 180f, 0, 0);
			return;
		}
		transform.rotation = new Quaternion (0, 0, 0, 0);
	}

	public void Jump () {
		if (onFloor && rb2D.velocity.y == 0) 
			rb2D.AddForce (new Vector2 (0, jumpForce));
	}

	private void InputControl () {
		if (CrossPlatformInputManager.GetButtonDown ("Jump"))
			Jump ();
	}
}
