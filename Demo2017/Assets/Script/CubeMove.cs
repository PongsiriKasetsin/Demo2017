using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour {

	public Rigidbody rg;
	public float velocity;


	void Start () {
		rg.velocity = new Vector3 (velocity, 0, 0); //
		//rg.AddForce(-1,0,0);
	}


	void Update () {
		
	}
}
