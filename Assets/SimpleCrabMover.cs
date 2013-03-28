using UnityEngine;
using System.Collections;

public class SimpleCrabMover : MonoBehaviour {

	private Vector3 targetPosition;
	private Vector3 MousePos;
	public float CrabMoveSpeed;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float amtToMove = CrabMoveSpeed * Time.deltaTime;
		if(Input.GetMouseButtonUp(0)){
			MousePos = Input.mousePosition;
		}
		
		targetPosition.z = -1 * MousePos.x;
		targetPosition.y = MousePos.y;
		
		
		float crabX = Camera.mainCamera.WorldToScreenPoint(this.transform.position).x;
		float crabY = Camera.mainCamera.WorldToScreenPoint(this.transform.position).y;
		
		Debug.Log ("x: " + crabX + " y: " + crabY);
		
		this.transform.Translate (new Vector3(0, MousePos.y - crabY, -1 * MousePos.x - crabX));
		
		//Vector3 heading = (targetPosition - transform.position).normalized;
		//this.transform.Translate(heading);
		//this.rigidbody.AddForce(heading*amtToMove);
		//if(transform.position == targetPosition){
			//rigidbody.drag = 1000;
		//}
	}
}
