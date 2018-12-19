using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreboard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public int s=0;
	public void incrementscore(int amt)
	{
		s += amt;
		print (s);
	}

}
