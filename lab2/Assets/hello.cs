// Trevor Tomesh
// CTCH 310 AD
// Lab 1
// Please comment your code -- pretty please. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//print ("Yo, Earth!");
		/* This is how we do block comments
		 */ 
	}
	
	// Update is called once per frame
	void Update () {
    Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;    
    move();
		print (myPos ());
			
	}



Vector3 myPos(){
		
		return this.transform.position;
	}

void move(){
    		if (Input.GetKey (KeyCode.W)) {

			transform.Translate (0f, 0f, 0.1f);

		}

    if(Input.GetKey(KeyCode.S)){
        transform.Translate(0f,0f,-0.1f);
    }
    
    float h = Input.GetAxis("Mouse X")*3.0f;
    float v = Input.GetAxis("Mouse Y") *2.0f;
    transform.Rotate(-v,h,0);
    
}
    
    
    
    
}