using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {
	
	public float speed ;


	// Use this for initialization
	void Start () {
		
    }
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.W) && transform.position.z ) {
			transform.Translate (Vector3.forward *speed *Time.deltaTime);
		}
		if (Input.GetKeyDown (KeyCode.S) && transform.position.z) {
			transform.Translate ( Vector3.back* speed*Time.deltaTime);
		}
		if (Input.GetKeyDown (KeyCode.A) && transform.position.x) {
			transform.Translate ( Vector3.left * speed *Time.deltaTime);
		}
		if (Input.GetKeyDown (KeyCode.D) && transform.position.x) {
			transform.Translate (Vector3.right * speed * Time.deltaTime);
		}
	}
}
