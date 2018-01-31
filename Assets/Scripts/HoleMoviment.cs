using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleMoviment : MonoBehaviour {

	public float speed;

	public Transform target;

	private Vector3 defaultPosition;

	void Start () {
		defaultPosition = transform.position;
	}

	void Update () {
		transform.localPosition = Vector3.MoveTowards (transform.localPosition, target.localPosition, speed);

		if (Vector3.Distance (transform.position, target.position) <= 0) {
			target.position = defaultPosition;
			defaultPosition = transform.position;
		}
	}
}
