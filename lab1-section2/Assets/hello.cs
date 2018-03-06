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
		if (Input.GetKey (KeyCode.W)) {

			transform.Translate (0f, 0f, 0.1f);


		}

		if (Input.GetKey (KeyCode.LeftArrow)) {

			transform.Rotate (0f, -1f, 0f);

		}
			
	}
}
