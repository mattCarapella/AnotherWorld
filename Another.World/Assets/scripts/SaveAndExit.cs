﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndExit : MonoBehaviour {

	void Start () {
		Vector3 pos = transform.position;
	}

	void Update() {
		Debug.Log ("save&exit x: " + transform.position.x);
		Debug.Log ("save&exit y: " + transform.position.y);
		Debug.Log ("save&exit z: " + transform.position.z);
	}

	public void saveAndExit() {
		Debug.Log ("AnotherWorld has exit");
		Application.Quit ();
	}
	//TODO: SAVE X, Y, Z TO DATABASE
}
