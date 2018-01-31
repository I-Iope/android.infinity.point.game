using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	public float speed;

	public Transform player;

	private Vector3 defaultPosition;

	void Start () {
		defaultPosition = transform.position;
	}
	
	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, player.position, speed);
	}

	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.gameObject.tag == "Hole") {
			speed += 0.001f;
			transform.position = defaultPosition;
		}
	}
}

