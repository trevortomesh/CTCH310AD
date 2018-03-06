/* program: follow.cs  
 * author: Trevor Tomesh
 * date: 13th Feb. 2018
 * ctch 310 AD 
 * 
 * This script makes the 
 * teddy follow your character
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

	public float speed;
	public GameObject player; 


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

     // Get the distance between two objects
		float dist = Vector3.Distance(player.transform.position, transform.position);

		Vector3 localPosition = player.transform.position - transform.position;
		localPosition = localPosition.normalized;

		if (dist < 10.0) {
			transform.Translate (localPosition.x * Time.deltaTime * speed, 
				0.0f,
				localPosition.z * Time.deltaTime * speed);
		}
		}

	}

