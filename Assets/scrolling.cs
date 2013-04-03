using UnityEngine;
using System.Collections;

public class scrolling : MonoBehaviour {
	public float scrollSpeed = 70;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	float mousePosX = Input.mousePosition.x; 
    float mousePosY = Input.mousePosition.y; 
    int scrollDistance = 3; 
 
    if (mousePosX < scrollDistance) 
         { 
          transform.Translate(Vector3.right * -scrollSpeed * Time.deltaTime); 
         } 
 
    if (mousePosX >= Screen.width - scrollDistance) 
         { 
          transform.Translate(Vector3.right * scrollSpeed * Time.deltaTime); 
         }
 
    if (mousePosY < scrollDistance) 
         { 
          transform.Translate(transform.up * -scrollSpeed * Time.deltaTime); 
         } 
 
    if (mousePosY >= Screen.height - scrollDistance) 
         { 
          transform.Translate(transform.up * scrollSpeed * Time.deltaTime); 
         }
    }
	}

