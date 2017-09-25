﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BasketController : MonoBehaviour {
	public Text scoreGT,scoreGO;     
	void Start () {
		scoreGO =  GameObject.Find("ScoreCounter").GetComponent<Text>();
		scoreGT = scoreGO.GetComponent<Text>();
		scoreGT.text = "0";
	}
	// Update is called once per frame
	void Update () {
		Vector3 mousePos2D = Input.mousePosition;
		mousePos2D.z = -Camera.main.transform.position.z;
		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint( mousePos2D );
		Vector3 pos = this.transform.position;
		pos.x = mousePos3D.x;
		this.transform.position = pos;
	}
	void OnCollisionEnter( Collision coll ) {
		// Find out what hit this basket
		GameObject collidedWith = coll.gameObject;
		if ( collidedWith.tag == "Apple" ) {
			Destroy( collidedWith );
		}
		int score = int.Parse(scoreGT.text);
		score += 100;
		scoreGT.text = score.ToString();
		if (score > HighScore.score) {
			HighScore.score = score;
		}
	}
}
