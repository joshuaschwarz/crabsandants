using UnityEngine;
using System.Collections;

public class Scoring : MonoBehaviour {

	// Use this for initialization
	
	// Update is called once per frame
	void OnGUI () {
	GUI.Label(new Rect(10, 30, 60, 20), "Score: ");
	}
}
