﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision){
		Destroy (collision.gameObject);
	}

	void OnTriggerEnter(Collider other){
		
		Destroy (other.gameObject);
	}
}
