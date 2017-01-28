using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneBall : MonoBehaviour {
	public Text txtScore;
	public Text txtAttack;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	int score = 0;
	int attack = 10;
	public void DoPushButton(){
		score++;
		attack++;
		txtScore.text = "Score :" + score.ToString ();
		txtAttack.text = "Attack :" + attack.ToString ();
	}

	public void DochangeScene(){
		SceneManager.LoadScene(1);
		}

}
