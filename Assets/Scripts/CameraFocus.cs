using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour {

	public int targetWidth;
	public int targetHeight;
	public float targetY;
	public float pixelsToUnitis;

	private Camera camera;

	void Start () {		
		int height = Mathf.RoundToInt(targetWidth / (float)Screen.width * Screen.height);

		camera = GetComponent<Camera> ();
		camera.orthographicSize = height / pixelsToUnitis / 2;

		float percentage = (float)height / targetHeight -1;
		percentage = percentage * -10;
		camera.transform.position = new Vector3 (camera.transform.position.x, targetY + (targetY * percentage), camera.transform.position.z);
	}
}
