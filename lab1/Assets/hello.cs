/*
Name: Trevor Tomesh
Date: 2018/01/24
Class: CTCH 310 AD
Assignment 1 (Lab 1 and 2)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("Yo, Earth!");
		print ("This is how we do it!");
	}
	
	// Update is called once per frame
	void Update () {
		//print ("Yo, Earth!");

        move();

			

	}
    
    
void move(){
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
		float n = 0.1f;


		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0f, 0f, n);

		}
    
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(0f,0f,-n);
        }

		if (Input.GetKey (KeyCode.RightArrow)) {

			transform.Rotate (0f, 1f, 0f);

		}
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(0f,-1f,0f);
        }
    
       if(Input.GetKey(KeyCode.A)){
           transform.Translate(-n,0f,0f);
       }
    
       if(Input.GetKey(KeyCode.D)){
           transform.Translate(n,0f,0f);
       }
    
   
        float h = Input.GetAxis("Mouse X")*3.0f;
        transform.Rotate(0f, h, 0f);
    
}    
}
