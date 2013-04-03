using UnityEngine;
using System.Collections;

public class TitleButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		float xloc = ((Screen.width)-200)/2;  //Adjust the position of the Button for multiple screen sizes
		float yloc = ((Screen.height)+50)/2;
		if (GUI.Button(new Rect(xloc, yloc,200,50),"Start Game")){ //Create a simple GUI Button to start the game. 
			Application.LoadLevel("background plane");
		}
	}
}