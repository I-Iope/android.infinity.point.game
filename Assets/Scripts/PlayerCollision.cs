using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {

	public PointController pointController;

	void Start () {
		pointController = FindObjectOfType<PointController> ();
	}
	
	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.gameObject.tag == "Enemy" ||coll.gameObject.tag == "Hole") {
			PlayerPrefs.SetString ("points", pointController.GetPoints());
			SceneManager.LoadScene (2, LoadSceneMode.Single);
		}
	}

}
