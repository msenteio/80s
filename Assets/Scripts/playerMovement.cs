using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour 
{
	public float speed          = 3.0f;
	public float jumpSpeed          = 200.0f;
	public bool grounded            = true;
	public float time           = 4.0f;     
	public Animator catwalk; 

	private Rigidbody2D rigidbody; 



	// Use this for initialization
	void Start () 
	{
		rigidbody = GetComponent<Rigidbody2D>();
		catwalk = GetComponent<Animator> (); 
		 
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		catwalk.SetLayerWeight (0, 1); 
		Vector3 x = Input.GetAxis("Horizontal")* transform.right * Time.deltaTime * speed;


		if (speed > 0) {
			catwalk.SetLayerWeight (1, 1);
			}

		//if (time <= 2)
		//{
			if(Input.GetKeyDown("space"))
			{
				Jump();
				
			}

		//}

		transform.Translate(x);

		//Restrict Rotation upon jumping of player object
		transform.rotation = Quaternion.LookRotation(Vector3.forward);


	}
	void Jump()
	{
		if (grounded == true)
		{
			rigidbody.AddForce(Vector3.up* jumpSpeed);


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