using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeadScene : MonoBehaviour {

	public Text point;

	void Start () {
		point.text = PlayerPrefs.GetString ("points", "0");
	}

	void Update () {
		if (Input.GetButtonDown("Space")) {
			SceneManager.LoadScene (1, LoadSceneMode.Single);
		}
	}
}
