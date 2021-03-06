﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	public Rigidbody rg;
	public float speed;
	public TextMesh txtBall;
	public GameObject dieEffectPerfab;

	void Start () {

	}

	void Update () {
		
	}

	public void Dojump(){
		rg.velocity = new Vector3 (0, 5, 0);
	}

	int countCollosion;
	void OnCollisionEnter(Collision collision) {
		Debug.LogFormat ("collision is (0)",collision.gameObject.tag);
		if (collision.gameObject.tag == "Floor") {
			countCollosion++;
			txtBall.text = "Floor : " + countCollosion.ToString ();
		}
//		else if(collision.gameObject.tag == "ceil")
//			Destroy(collision.gameObject);
	
	}	
		
	public void SetDieCallBack(System.Action callback){
		dieCallBack = callback;
	}

	System.Action dieCallBack;

	void OnDestroy() {
		SceneBall.life--;
		GameObject dieEffect = Instantiate (dieEffectPerfab);
		dieEffect.transform.position = this.gameObject.transform.position;
		dieCallBack ();
	}

}
