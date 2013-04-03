using UnityEngine;
using System.Collections;

public class Level1Master : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Scored(){
		if(GameObject.Find("Crab")) {
			Application.LoadLevel("level 2");
	}
}
}
