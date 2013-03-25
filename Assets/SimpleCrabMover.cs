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
		targetPosition.x = MousePos.x;
		targetPosition.y = MousePos.y;
		Vector3 heading = (targetPosition - transform.position).normalized;
		this.rigidbody.AddForce(heading*amtToMove);
		if(transform.position == targetPosition){
			//rigidbody.drag = 1000;
		}
	}
}
