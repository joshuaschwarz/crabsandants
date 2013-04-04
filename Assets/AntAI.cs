//Joshua Schwarz
//An artificial intelligence algorithm for the ants.
//This is not one discussed in class.
//I don't want the ants to be too intelligent (by using someting like A*)...
//Instead, ants will wander until they hit obstacles and then try to get around them.

using UnityEngine;
using System.Collections;

public class AntAI : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	public bool col = false;
	
	public bool doNotGoUp = false;
	public int doNotGoUpDelay = 0;
	
	public bool doNotGoDown = false;
	public int doNotGoDownDelay = 0;
	
	public bool doNotGoLeft = false;
	public int doNotGoLeftDelay = 0;
	
	public bool doNotGoRight = false;
	public int doNotGoRightDelay = 0;
	
	int provocationDistance = 200; //when a crab is within this many units (distance formula) from an ant, ant chases
	
	int baseDelay = 200;
	int speed = 1;
	
	// Update is called once per frame
	void Update () {
		GameObject[] go = GameObject.FindGameObjectsWithTag("Crab");
		foreach(GameObject crab in go)
		{
			//check if crab is in sight
			float absYDistanceFormula = Mathf.Abs(crab.transform.position.y - this.transform.position.y);
			float absXDistanceFormula = Mathf.Abs(crab.transform.position.x - this.transform.position.x);
			if(Mathf.Sqrt(absXDistanceFormula * absXDistanceFormula + absYDistanceFormula * absYDistanceFormula) <= provocationDistance)
			{
				if(absYDistanceFormula > 5)
					UpDown (crab);
				else if(absXDistanceFormula > 5)
					LeftRight (crab);
				
				//Adjust delays... ants wait a while before trying to go a certain direction again after hitting an obstacle
				doNotGoUpDelay--;
				doNotGoDownDelay--;
				doNotGoLeftDelay--;
				doNotGoRightDelay--;
				if(doNotGoUpDelay <= 0)
				{
					doNotGoUp = false;	
					doNotGoUpDelay = 0;
				}
				if(doNotGoDownDelay <= 0)
				{
					doNotGoDown = false;
					doNotGoDownDelay = 0;
				}
				if(doNotGoLeftDelay <= 0)
				{
					doNotGoLeft = false;	
					doNotGoLeftDelay = 0;
				}
				if(doNotGoRightDelay <= 0)
				{
					doNotGoRight = false;
					doNotGoRightDelay = 0;
				}
				break;	
			}
		}
	}
	
	void UpDown(GameObject crab)
	{
		//UP and DOWN logic and workarounds
		if(!doNotGoUp && (crab.transform.position.y - this.transform.position.y) >= 0)
		{
			GoUp (speed);
		}
		else if(!doNotGoDown && (crab.transform.position.y - this.transform.position.y) <= 0)
		{
			GoDown (speed);
		}
		else if((doNotGoUp || doNotGoDown) && !doNotGoRight)
		{
			GoRight (speed);
		}
		else if((doNotGoDown || doNotGoUp) && !doNotGoLeft)
		{
			GoLeft (speed);
		}
	}
	
	void LeftRight(GameObject crab)
	{
		//LEFT and RIGHT logic and workarounds
		if(!doNotGoLeft && (crab.transform.position.x - this.transform.position.x) >= 0)
		{
			GoLeft (speed);
		}
		else if(!doNotGoRight && (crab.transform.position.x - this.transform.position.x) <= 0)
		{
			GoRight (speed);
		}
		else if((doNotGoLeft || doNotGoRight) && !doNotGoUp)
		{
			GoUp (speed);
		}
		else if((doNotGoLeft || doNotGoRight) && !doNotGoDown)
		{
			GoDown (speed);
		}		
	}
	
	void GoLeft(int magnitude)
	{
		if(col)
		{
			doNotGoLeft = true;
			doNotGoLeftDelay = baseDelay;
			col = false;
			GoRight (speed * 2);
		}
		else
		{
			this.transform.Translate (new Vector3(magnitude,0,0));	
		}
	}
	
	void GoRight(int magnitude)
	{
		if(col)
		{
			doNotGoRight = true;
			doNotGoRightDelay = baseDelay;
			col = false;
			GoLeft (speed * 2);
		}
		else
		{
			this.transform.Translate (new Vector3(-1 * magnitude,0,0));	
		}
	}
	
	void GoUp(int magnitude)
	{
		if(col)
		{
			doNotGoUp = true;
			doNotGoUpDelay = baseDelay;
			col = false;
			GoDown (speed * 2);
		}
		else
		{
			this.transform.Translate (new Vector3(0,magnitude,0));	
		}
	}
	
	void GoDown(int magnitude)
	{
		if(col)
		{
			doNotGoDown = true;
			doNotGoDownDelay = baseDelay;
			col = false;
			GoUp (speed * 2);
		}
		else
		{
			this.transform.Translate (new Vector3(0,-1 * magnitude,0));	
		}
		
	}
	
	//handle collisions with obstacles and killing of crabs
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Obstacle")
		{
			col = true;
		}
		else if(other.tag == "Crab")
		{
			other.gameObject.SendMessage("Killed");
		}
	}
	
}
