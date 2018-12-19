using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelmanager : MonoBehaviour {

	// Use this for initialization
	public float TimeTillNextLevel=30.0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(TimeTillNextLevel>0)
		{
			TimeTillNextLevel-=Time.deltaTime;
			if(TimeTillNextLevel<0)
			LoadNextScene();	
		}
	}
	public void LoadNextScene()
	{
		int current_index = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (current_index + 1);

	}
}
