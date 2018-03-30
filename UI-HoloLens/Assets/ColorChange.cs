using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

	public GameObject myCube;

	// Use this for initialization
	void Start () {
		myCube = GameObject.Find("MyCube"); // Get the cube GameObject
	}

	public void colorBlue() { // Set color of cube to blue
		Renderer rend = myCube.GetComponent<Renderer>();
		rend.material.color = Color.blue;
	}

	public void colorGreen() {
		Renderer rend = myCube.GetComponent<Renderer>();
		rend.material.color = Color.green;
	}

	public void colorRed() {
		Renderer rend = myCube.GetComponent<Renderer>();
		rend.material.color = Color.red;
	}
}
