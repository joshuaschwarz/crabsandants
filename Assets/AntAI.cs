using UnityEngine;
using System.Collections;

public class AntAI : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	public bool col = false;
	
	public bool doNotGoUp = false;
	public bool doNotGoDown = false;
	public bool doNotGoLeft = false;
	public bool doNotGoRight = false;
	
	// Update is called once per frame
	void Update () {
		GameObject[] go = GameObject.FindGameObjectsWithTag("Crab");
		foreach(GameObject crab in go)
		{
			//check if crab is in sight (for now, assuming crab always in sight for testing)
			if(true)
			{
				//Crab is above the ant, so move up
				if(!doNotGoUp && crab.transform.position.y > this.transform.position.y)
				{
					GoUp ();
				}
				else if(!doNotGoDown)
				{
					GoDown ();
				}
				else if(doNotGoDown && !doNotGoRight)
				{
					GoRight ();
				}
				
				break;	
			}
		}
	}
	
	void GoLeft()
	{
		if(col)
		{
			doNotGoLeft = true;
			col = false;
		}
		else
		{
			this.transform.Translate (new Vector3(1,0,0));	
		}
	}
	
	void GoRight()
	{
		if(col)
		{
			doNotGoRight = true;
			col = false;
		}
		else
		{
			this.transform.Translate (new Vector3(-1,0,0));	
		}
	}
	
	void GoUp()
	{
		if(col)
		{
			doNotGoUp = true;
			col = false;
		}
		else
		{
			this.transform.Translate (new Vector3(0,1,0));	
		}
	}
	
	void GoDown()
	{
		if(col)
		{
			doNotGoDown = true;
			col = false;
		}
		else
		{
			this.transform.Translate (new Vector3(0,-1,0));	
		}
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Obstacle")
		{
			Debug.Log ("col");
			col = true;
		}
	}
	
}
