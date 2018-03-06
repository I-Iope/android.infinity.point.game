using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class TutorialController : MonoBehaviour {
	
	public Sprite[] images;
	public Image canvasImage;

	public float fadeTime;

	private int position = 0;

	IEnumerator Start () {
		canvasImage.sprite = images [position];
		canvasImage.canvasRenderer.SetAlpha (0.0f);
		canvasImage.CrossFadeAlpha (1.0f, fadeTime, false);
		yield return null;
	}

	void Update () {
		if (CrossPlatformInputManager.GetButtonDown ("Jump"))
			SwitchImage (++position);
	}

	void SwitchImage (int pos) {		
		if (pos == images.Length) {
			SceneManager.LoadScene ("Menu", LoadSceneMode.Single);
			return;
		}
		
		canvasImage.sprite = images [pos];
	}
}
