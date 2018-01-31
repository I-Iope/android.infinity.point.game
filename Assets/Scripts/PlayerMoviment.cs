using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
		horizontal = Input.GetAxis ("Horizontal");
		IsOnFloor ();
		InputControl ();
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

	public void Jump () {
		if (onFloor && rb2D.velocity.y <= 0) {
			rb2D.AddForce (new Vector2 (0, jumpForce));
		}
	}

	private void InputControl () {
		if (Input.GetButtonDown ("Jump")) {
			Jump ();
		}
	}
}
