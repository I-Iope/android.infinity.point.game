using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoviment : MonoBehaviour {

	public float speed;

	public Transform target;
	public Transform player;

	private Vector3 defaultPosition;

	void Start () {
		defaultPosition = transform.position;
	}

	void Update () {
		transform.localPosition = Vector3.MoveTowards (transform.localPosition, target.localPosition, speed);		

		if (Vector3.Distance(transform.position, target.position) <= 0) {
			target.position = defaultPosition;
			defaultPosition = transform.position;
		}
	}

	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.gameObject.tag == "Player") {
			coll.transform.SetParent (transform);
		}
	}

	void OnCollisionExit2D (Collision2D coll) {
		if (coll.gameObject.tag == "Player") {
			coll.transform.SetParent (null);
		}
	}
}
