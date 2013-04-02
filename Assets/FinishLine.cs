using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {

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
			//gamemaster.SendMessage("Scored");//delete if we don't end up scoring
		}
	}
}
