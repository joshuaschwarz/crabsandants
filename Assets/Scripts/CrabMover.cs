/*Andrew Heckman
 * EECS 290
 * Strategy game
 */
using UnityEngine;
using System.Collections;

public class CrabMover : MonoBehaviour {
 
public float CrabMoveSpeed;
private Vector3 TargetPosition;
private Transform CrabTransform;
 
 
void Start () 
{
    CrabTransform = transform;
	TargetPosition = CrabTransform.position;
}
 
void Update () 
{          
    //Amount to move, move speed
    float amtToMove = CrabMoveSpeed * Time.deltaTime;
 
    //Move the Player after they have clicked the Left Mouse Button on a location
	//TODO: stop it from moving in the 3rd dimension (Might just require camera manipulation!)
	//TODO: slow down movement
    if (Input.GetMouseButtonDown(0))
    {
       Plane playerPlane = new Plane(Vector3.up, CrabTransform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitdist = 0.0f;
 
       if (playerPlane.Raycast(ray, out hitdist)) 
       {
            Vector3 targetPoint = ray.GetPoint(hitdist);
            TargetPosition = ray.GetPoint(hitdist);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            CrabTransform.rotation = targetRotation;
       }               
    }
 
    CrabTransform.position = Vector3.Lerp(CrabTransform.position, TargetPosition, amtToMove);
}
}