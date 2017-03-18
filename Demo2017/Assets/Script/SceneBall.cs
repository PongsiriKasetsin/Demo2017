using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneBall : MonoBehaviour {
	public Text txtScore;
	public Text txtAttack;
	public GameObject obtacleprefab;
	public GameObject moneyprefab;
	public Text txtlife;
	public GameObject Ballprefab;
	public Button btnjump;

	// Use this for initialization
	void Start () {
		DotestObtacle ();
		CreateBall ();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateText();
	}



	void UpdateText(){
		txtScore.text = "Score :" + score.ToString ();
		txtlife.text = "Life :" + score.ToString ();
	}



	public static int score = 0; 
	public static int life = 25; 
	int attack = 10;
	public void DoPushButton(){
		score++;
		attack++;
		txtScore.text = "Score :" + score.ToString ();
		txtAttack.text = "Attack :" + attack.ToString ();
		txtlife.text = "Life :" + life.ToString ();
	}


	public void DochangeScene(){
		SceneManager.LoadScene(1);
		}

	public void DotestObtacle(){
		StartCoroutine (Gameprocess());
	}

	IEnumerator Gameprocess(){

		for (int i = 0; i < 10; i++) 
		{
			GameObject obtacle = Instantiate (obtacleprefab);
			float positionY = Random.Range (6,-0.78f);
			obtacle.transform.position = new Vector3 (6, positionY, 0);

			GameObject money = Instantiate (moneyprefab);
			money.transform.position = new Vector3 (5.55f, positionY + 1.33f+Random.Range(0,2), 0);
			yield return new WaitForSeconds(1);
		}
	}

	void CreateBall(){
		BallController control = Instantiate (Ballprefab).GetComponent<BallController> ();
		control.SetDieCallBack (CreateBall);
		btnjump.onClick.AddListener (control.Dojump);
	}
}
