using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topdownMove : catMove {

	public Animator catMove;
	// Use this for initialization
	 void Start () {
		catMove = GetComponent<Animator> (); 
	}
	
	// Update is called once per frame
	public override void MoveForward () {

		 if(Input.GetKey("down"))//Press up arrow key to move forward on the Y AXIS
		{
			transform.Translate(0,-playerSpeed * Time.deltaTime,0);
			catMove.SetLayerWeight (4, 0);
			catMove.SetLayerWeight (3, 1); 
			catMove.SetLayerWeight (2, 0); 
			catMove.SetLayerWeight (1, 0); 
			catMove.SetLayerWeight (0, 0); 
		}
		else if(Input.GetKey("left"))//Press up arrow key to move forward on the Y AXIS
		{
			transform.Translate(-playerSpeed * Time.deltaTime,0 ,0);
			catMove.SetLayerWeight (1, 1); 
			catMove.SetLayerWeight (0, 0); 
			catMove.SetLayerWeight (2, 0); 
			catMove.SetLayerWeight (3, 0); 
			catMove.SetLayerWeight (4, 0); 
		}
		else if (Input.GetKey ("right")) {//Press up arrow key to move forward on the Y AXIS
			transform.Translate (playerSpeed * Time.deltaTime, 0, 0);
			catMove.SetLayerWeight (2, 1); 
			catMove.SetLayerWeight (3, 0); 
			catMove.SetLayerWeight (4, 0); 
			catMove.SetLayerWeight (1, 0); 
			catMove.SetLayerWeight (0, 0); 
		} else {
			catMove.SetLayerWeight (0, 1); 
			catMove.SetLayerWeight (1, 0); 
			catMove.SetLayerWeight (2, 0); 
			catMove.SetLayerWeight (3, 0); 
			catMove.SetLayerWeight (4, 0); 
		}

	}

	public override void Jump () {
		if(Input.GetKey("up"))//Press up arrow key to move forward on the Y AXIS
		{
			transform.Translate(0,playerSpeed * Time.deltaTime,0);
			catMove.SetLayerWeight (3, 0); 
			catMove.SetLayerWeight (0, 0); 
			catMove.SetLayerWeight (1, 0); 
			catMove.SetLayerWeight (2, 0); 
			catMove.SetLayerWeight (4, 1); 
		}
	
	}
		
		

}
