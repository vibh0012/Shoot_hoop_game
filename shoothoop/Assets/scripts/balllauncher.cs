using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balllauncher : MonoBehaviour {
	public GameObject ballprefab;
	public float ballspeed=25.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
		{
			GameObject Instance= Instantiate(ballprefab);
			Instance.transform.position = transform.position;
			Rigidbody rb = Instance.GetComponent<Rigidbody> ();
			Camera camera = transform.GetComponentInChildren<Camera> ();
			rb.velocity = camera.transform.rotation*Vector3.forward*ballspeed; 

		}
	}
}