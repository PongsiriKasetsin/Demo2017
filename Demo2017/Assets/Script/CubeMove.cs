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

	void OnCollisionEnter(Collision collision) {
		//Debug.LogFormat ("collision is (0)",collision.gameObject.tag);
		if (collision.gameObject.tag == "Ball") {
			Destroy (collision.gameObject);
		}
	}

}
