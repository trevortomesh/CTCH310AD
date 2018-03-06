using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

	public float speed; 
	public GameObject player; 
	public float triggerDist;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance (player.transform.position, transform.position);
		Vector3 localPosition = player.transform.position - transform.position;
		localPosition = localPosition.normalized; 

		if (dist < triggerDist) {
			transform.Translate (localPosition.x * Time.deltaTime * speed, 
				localPosition.y * Time.deltaTime * speed,
				localPosition.z * Time.deltaTime * speed);


		}
	}
}
