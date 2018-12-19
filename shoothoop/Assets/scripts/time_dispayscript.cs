using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time_dispayscript : MonoBehaviour {

	Text text;
	levelmanager manager;

	// Use this for initialization
	void Start () {

		manager = FindObjectOfType<levelmanager> ();
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

		text.text = "TIME REMAINING =  " + manager.TimeTillNextLevel;
	}
}
