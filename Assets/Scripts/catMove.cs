using UnityEngine;
using System.Collections;

public class catMove : MonoBehaviour
{
	//Inspector Variables

	public float speed          = 3.0f;
	public float jumpSpeed          = 200.0f;
	public bool grounded            = true;
	public float time           = 4.0f;     
	public Animator catwalk; 
	public Rigidbody2D rigidbody;


	public float playerSpeed = 50; //speed player moves

	void Start () {
		rigidbody = GetComponent<Rigidbody2D>();
		catwalk = GetComponent<Animator> ();

	}

	void FixedUpdate() 
	{
//		catwalk.SetLayerWeight (0, 1); 
		//Vector3 x = Input.GetAxis("Horizontal")* transform.right * Time.deltaTime * speed;
//
//
//		if (speed > 0) {
//			catwalk.SetLayerWeight (1, 1);
//		}
//
		//if (time <= 2)
		//{
		if(Input.GetKeyDown("space"))
		{
			Jump();


		}
		if (Input.GetKeyDown ("space")) {
		
			catwalk.SetLayerWeight (3, 1);
			catwalk.SetLayerWeight (2, 0); 
			catwalk.SetLayerWeight (1, 0); 
			catwalk.SetLayerWeight (0, 0); 
		}

		//}

		//transform.Translate(x);

		//Restrict Rotation upon jumping of player object
		transform.rotation = Quaternion.LookRotation(Vector3.forward);
		MoveForward(); // Player Movement 
	}

	public virtual void MoveForward()
	{

//		if(Input.GetKey("up"))//Press up arrow key to move forward on the Y AXIS
//		{
//			transform.Translate(0,playerSpeed * Time.deltaTime,0);
//			catwalk.SetLayerWeight (3, 1);  
		//{
//		 if(Input.GetKey("down"))//Press up arrow key to move forward on the Y AXIS
//		{
//			transform.Translate(0,-playerSpeed * Time.deltaTime,0);
//			catwalk.SetLayerWeight (4, 1);
//		
//		}
		 if(Input.GetKey("left"))//Press up arrow key to move forward on the Y AXIS
		{
			transform.Translate(-playerSpeed * Time.deltaTime, 0 ,0);
			catwalk.SetLayerWeight (1, 0); 
			catwalk.SetLayerWeight (0, 0); 
			catwalk.SetLayerWeight (2, 1); 
			catwalk.SetLayerWeight (3, 0); 


		 
		}
		 if (Input.GetKey ("right")) {//Press up arrow key to move forward on the Y AXIS
			transform.Translate (playerSpeed * Time.deltaTime, 0, 0);
			catwalk.SetLayerWeight (1, 1);
			catwalk.SetLayerWeight (0, 0); 
			catwalk.SetLayerWeight (2, 0); 
			catwalk.SetLayerWeight (3, 0); 


		
		}  if (Input.anyKey == false){
			catwalk.SetLayerWeight (0, 1); 
			catwalk.SetLayerWeight (1, 0); 
			catwalk.SetLayerWeight (2, 0); 
			catwalk.SetLayerWeight (3, 0); 
			 
		}
	}

	public virtual void Jump()
	{
		if (grounded == true)
		{
			rigidbody.AddForce(Vector3.up * jumpSpeed);


			grounded = false;
		}

	}

	void OnCollisionEnter2D (Collision2D hit)
	{
		grounded = true;
		// check message upon collition for functionality working of code.
		Debug.Log ("I am colliding with something");
	}

}
