using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedAreaScipt : MonoBehaviour {


	public Light targetlight;

	void OnTriggerEnter ( Collider other ) {
		Debug.Log ("Exit");
		if (other.CompareTag ("Player")) {
			targetlight.enabled = false;
			//targetlight.color = Color.blue;
		}
	}
}

