using UnityEngine;
using System.Collections;

public class SuperSimpleCrabMover : MonoBehaviour {
	
	public float crabSpeed = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(Vector3.right*Time.deltaTime*crabSpeed);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(Vector3.left*Time.deltaTime*crabSpeed);
		}
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(Vector3.up*Time.deltaTime*crabSpeed);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(Vector3.down*Time.deltaTime*crabSpeed);
		}
		
	}
	
	void Scored(){
		this.gameObject.SetActive(false);
	}
	
	void Killed(){
		this.gameObject.SetActive(false);
	}
}
