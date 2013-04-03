using UnityEngine;
using System.Collections;

public class SimpleCrabMover : MonoBehaviour {

	public float CrabMoveSpeed;
	private float crabX = 0;
	private float crabY = 0;
	private float score = 0;
	private Quaternion rotLock = new Quaternion(0,0,0,0);
	// Use this for initialization
	void Start () {
		crabX = Camera.mainCamera.WorldToScreenPoint(this.gameObject.transform.position).x;
		crabY = Camera.mainCamera.WorldToScreenPoint(this.gameObject.transform.position).y;
		mouseButtonClickPosition = new Vector3(crabX,crabY,0f);
	}
	
	Vector3 mouseButtonClickPosition = new Vector3();
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetMouseButtonUp (0))
		{
			mouseButtonClickPosition = Input.mousePosition;
		}
		float amtToMove = CrabMoveSpeed * Time.deltaTime;
		
		crabX = Camera.mainCamera.WorldToScreenPoint(this.gameObject.transform.position).x;
		crabY = Camera.mainCamera.WorldToScreenPoint(this.gameObject.transform.position).y;
		Vector3 CrabPos = new Vector3(crabX,crabY,0);
		
		Vector3 towardsTarget = mouseButtonClickPosition - CrabPos;
		Debug.Log (towardsTarget.x + "," + towardsTarget.y);
		towardsTarget.z = 0;
		towardsTarget.x = towardsTarget.x * -1;
		if(towardsTarget.magnitude != 0)
		{
			this.transform.Translate (towardsTarget / towardsTarget.magnitude * amtToMove);
		}
		
		this.gameObject.transform.rotation = rotLock;
	}
	
	void Scored(){
		
		this.gameObject.SetActive(false);
	}
	
	void Killed(){
		this.gameObject.SetActive(false);
	}
}
