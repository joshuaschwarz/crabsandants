using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {
	public static float score = 0;
	// Use this for initialization
	void Start () {
		//GameObject gamemaster = GameObject.Find("GameMaster");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	void OnTriggerEnter(Collider collision){
		Debug.Log(collision.gameObject.name);
		if(collision.gameObject.name == "Crab"){ 
			score++;
			collision.gameObject.SendMessage("Scored");	
			//SendMessage("Scored", score);//delete if we don't end up scoring
		}
		
	}
	void OnGUI () {
	GUI.Label(new Rect(10, 30, 60, 20), "Score: " + score);
	}
}

