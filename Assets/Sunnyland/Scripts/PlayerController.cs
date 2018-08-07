using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;             //Floating point variable to store the player's movement speed.

	private Rigidbody2D rb2d;
	//Store a reference to the Rigidbody2D component required to use 2D Physics.
	private Animator ani1;
	private Vector2 movement;
	// Use this for initialization
	void Start()
	{
		ani1 = GetComponent<Animator>();
		//Get and store a reference to the Rigidbody2D component so that we can access it.
		rb2d = GetComponent<Rigidbody2D> ();

	}

	//FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
	void FixedUpdate()
	{
		//Store the current horizontal input in the float moveHorizontal.
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		movement = new Vector2 (moveHorizontal, moveVertical);

		if(moveHorizontal != 0)
		{
			rb2d.AddForce (movement * speed);
			ani1.SetBool ("walking", true);

		}
		else {
			ani1.SetBool ("walking", false);
		}

		//Store the current vertical input in the float moveVertical.


		if(moveHorizontal != 0)
		{
			rb2d.transform.Translate (movement);
			ani1.SetBool ("walking", true);
		}
		else {
			ani1.SetBool ("walking", false);
		}
		//Use the two store floats to create a new Vector2 variable movement.


		//Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.

	
	}
}