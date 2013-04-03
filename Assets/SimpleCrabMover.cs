using UnityEngine;
using System.Collections;

public class SimpleCrabMover : MonoBehaviour {

	public float CrabMoveSpeed;
	private float crabX = 0;
	private float crabY = 0;
	private float score = 0;
	// Use this for initialization
	void Start () {
		crabX = this.transform.position.x;
		crabY = this.transform.position.y;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float amtToMove = CrabMoveSpeed * Time.deltaTime;

		if(Input.GetMouseButtonUp(0)){
			//MousePos = Input.mousePosition;
		

		
		//targetPosition.z = -1 * MousePos.x;
		//targetPosition.y = MousePos.y;
		
		
		crabX = Camera.mainCamera.WorldToScreenPoint(this.transform.position).x;
		crabY = Camera.mainCamera.WorldToScreenPoint(this.transform.position).y;
		}
		Debug.Log ("x: " + crabX + " y: " + crabY);
		
		
		Vector3 MousePos = new Vector3(crabX,crabY,0);
		Vector3 towardsTarget = MousePos - this.transform.position;
		towardsTarget.z = 0;
    	this.transform.position += towardsTarget.normalized * amtToMove;
		
		/*if(this.transform.position == MousePos){
			this.transform.Translate(Vector3.up * amtToMove,Space.World);
			this.transform.Translate(Vector3.right * amtToMove,Space.World);
		}*/
	}
	
	void Scored(){
		
		this.gameObject.SetActive(false);
	}
	
	void Killed(){
		this.gameObject.SetActive(false);
	}
}
