using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfect : MonoBehaviour {

	public float pixelsToUnit;
	
	void Update () {
		GetComponent<Camera> ().orthographicSize = (Screen.height / pixelsToUnit) / 2;
	}

}
