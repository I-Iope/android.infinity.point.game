using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneScript : MonoBehaviour {

	public void OnClickStartGame () {
		SceneManager.LoadScene ("Main Scene", LoadSceneMode.Single);
	}

	public void OnClickExit() {
		Application.Quit ();
	}

	public void OnClickTutorial() {
		SceneManager.LoadScene ("Tutorial", LoadSceneMode.Single);
	}
}
