using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {
	public float score = 0;
	// Use this for initialization
	void Start () {
		//GameObject gamemaster = GameObject.Find("GameMaster");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	void onCollisionEnter(Collision collision){
		if(collision.gameObject.name == "Crab"){ 
			collision.gameObject.SendMessage("Scored");	
			score++;
			//SendMessage("Scored", score);//delete if we don't end up scoring
		}
		
	}
	void OnGUI () {
	GUI.Label(new Rect(10, 30, 60, 20), "Score: " + score);
	}
}

