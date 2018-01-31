using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
	
	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.gameObject.tag == "Enemy" ||coll.gameObject.tag == "Hole") {
			Debug.Log ("collision");
		}
	}

}
