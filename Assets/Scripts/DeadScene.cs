using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class DeadScene : MonoBehaviour {

	public Text point;
	public Text record;

	void Start () {
		point.text = PlayerPrefs.GetString ("points", "0");
		record.text = PlayerPrefs.GetString ("record", "0");

		if (int.Parse(record.text) < int.Parse(point.text)) {
			PlayerPrefs.SetString ("record", point.text);
			record.text = point.text;
		} 
	}

	void Update () {
		if (CrossPlatformInputManager.GetButtonDown("Jump")) {
			SceneManager.LoadScene (1, LoadSceneMode.Single);
		}
	}
}
