﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyController : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	 
	// Update is called once per frame
	void Update () {
		float speedmoney = Time.deltaTime * this.speed;
		gameObject.transform.position = new Vector3 (gameObject.transform.position.x -speed,gameObject.transform.position.y,0); //move left
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.gameObject.tag == "Ball") {
			SceneBall.score++;
			Destroy (gameObject);
		}else if(other.gameObject.gameObject.tag == "Boundary"){
			Destroy (this.gameObject);
		}
	}

}
