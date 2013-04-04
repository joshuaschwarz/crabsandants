using UnityEngine;
using System.Collections;

public class Level2Master : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update(){
		GameObject[] objects = GameObject.FindGameObjectsWithTag("Crab");
		int numberNotActive = 0;
		foreach(GameObject go in objects)
		{
			if(go.activeSelf == false)
			{
				numberNotActive++;	
			}
		}
		if(numberNotActive == objects.Length && FinishLine.score > 0)
		{
			FinishLine.score = 0;
			Application.LoadLevel("Level 3");
		}
	}
}
