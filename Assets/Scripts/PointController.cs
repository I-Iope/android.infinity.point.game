using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour {

	public Text uiText;

	void Start () {
		uiText.text = "0";
	}

	public void AddPoint () {
		int points = int.Parse (uiText.text);
		points = ++points;
		uiText.text = points.ToString(); 
	}

	public string GetPoints () {
		return uiText.text;
	}
}
