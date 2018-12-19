using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targethit : MonoBehaviour {
	public int ptsperhit=1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {}
	void OnCollisionEnter(Collision collision)
		{
		scoreboard score = FindObjectOfType<scoreboard> ();
		score.incrementscore (ptsperhit);

		}
}
