using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelLoader : MonoBehaviour {



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}




	void OnCollisionEnter2D (Collision2D hit){

		Application.LoadLevel("room");
		// check message upon collition for functionality working of code.
		Debug.Log ("I am colliding with something");
	}
}
