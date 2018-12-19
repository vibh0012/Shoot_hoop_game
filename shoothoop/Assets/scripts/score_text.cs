using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_text : MonoBehaviour {

	scoreboard score1;
	Text text;
	// Use this for initialization
	void Start () {

		score1 = FindObjectOfType<scoreboard> ();
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = "SCORE=" + score1.s;
	}
}
