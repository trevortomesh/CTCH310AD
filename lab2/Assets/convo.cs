// Trevor Tomesh
// CTCH 310 AD 
// Lab 4 - Section 2
// Feb. 7th 2018
// This is a basic switch statement script -- it doesn't do much useful...
// ------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class convo : MonoBehaviour {
	public int intelligence = 5; 


	void Greetings(){
		switch (intelligence) {
		case 5: //Genius level intelligence
			print ("Why, ello there -- would you like to discuss quantum mechanics?");
			break;
		case 4: //average intelligence
			print ("Hey there -- what's up?");
			break; 
		case 3: //not so bright...
			print ("Whaddya want?!?!");
			break;
		case 2: //stupid
			print ("Teddy angry! Teddy smash face!");
			break;
		case 1: //reaaaaaaaly stupid
			print ("Ppppfffftthblblblblbl *fart*");
			break;

		default: 
			print ("Invalid intelligence level!");
			break;

		}
	}
	// Use this for initialization
	void Start () {

			Greetings();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
