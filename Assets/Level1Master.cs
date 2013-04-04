using UnityEngine;
using System.Collections;

public class Level1Master : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Scored(){
		if(GameObject.FindGameObjectsWithTag("Crab").Length == 0) {
			Application.LoadLevel("Level 2");
	}
}
}
