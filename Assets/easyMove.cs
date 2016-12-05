using UnityEngine;
using System.Collections;

public class easyMove : MonoBehaviour {

	public float Speed = 0f;
	private float movex = 0f;
	private float movey = 0f;
	private Rigidbody2D rigid; 

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		rigid.velocity = new Vector2 (movex * Speed, movey * Speed);
	}
}

