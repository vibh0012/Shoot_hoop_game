using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float mousex = Input.GetAxis ("Mouse X")*20;
		float mousey = Input.GetAxis ("Mouse Y")*20;
		transform.localRotation = Quaternion.Euler (0, mousex, 0) * transform.localRotation;
		Camera camera = transform.GetComponentInChildren<Camera> ();
		camera.transform.localRotation = Quaternion.Euler (-mousey, 0, 0) * camera.transform.localRotation;


	}
}
