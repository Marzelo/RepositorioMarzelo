using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueAreaScipt : MonoBehaviour {
	
	public Light targetlight;

	void OnTriggerEnter ( Collider other ) {
		Debug.Log ("Enter");
		if (other.CompareTag ("Player")) {
			targetlight.enabled = true;
		}
	}
}
