using UnityEngine;
using System.Collections;

public class AntAI : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] go = GameObject.FindGameObjectsWithTag("Crab");
		foreach(GameObject crab in go)
		{
			//check if crab is in sight (for now, assuming crab always in sight for testing)
			if(true)
			{
				//Crab is above the ant, so move up
				if(crab.transform.position.y > this.transform.position.y)
				{
					this.transform.Translate (new Vector3(0,1,0));	
				}
				else 
				{
					this.transform.Translate (new Vector3(0,-1,0));	
				}
					
			}
		}
	}
}
