﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyResponse : MonoBehaviour {

    public AudioClip hitSound;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTrigerEnter (Collider other){
        if (other.CompareTag("PlayerBullet")){
            GetComponent<AudioSource>().PlayOneShot(hitSound);
            //ShootingRangeControl
            Destroy(other.gameObject);
        }
    }
}
