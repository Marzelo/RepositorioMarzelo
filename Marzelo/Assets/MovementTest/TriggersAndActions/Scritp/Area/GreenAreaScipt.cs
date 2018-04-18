using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenAreaScipt : MonoBehaviour {


	public Light targetlight;
	public bool runUpdate;
	float timer = 0;

	void OnTriggerStay ( Collider other ) {
		//Debug.Log ("Stay");
		if ( other.CompareTag ("Player") && !runUpdate) {
			runUpdate = true;
		}
	}

	void OntriggerExit(Collider other){
		if (other.CompareTag ("Player")) {
			runUpdate = false;
		}

	}


	void Update () {
		if (runUpdate){
			timer += Time.deltaTime;
			if (timer >= -1) {
				targetlight.enabled = !targetlight.enabled;
			}
		}
	}
}
