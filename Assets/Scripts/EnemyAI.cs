using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	public float speed;

	public Transform player;

	private Vector3 defaultPosition;

	public PointController pointController;

	void Start () {
		defaultPosition = transform.position;
		pointController = FindObjectOfType<PointController>();
	}
	
	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, player.position, speed);
	}

	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.gameObject.tag == "Hole") {
			speed += 0.001f;
			pointController.AddPoint ();
			transform.position = defaultPosition;
		}
	}
}

