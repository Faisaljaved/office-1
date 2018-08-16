using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;           
	private float moveHorizontal;
	private float moveVertical;
	private Rigidbody2D rb2d;

	private Animator ani1;
	private Vector2 movement;
	public bool grounded;
	public float jumpforce;
	private bool jump;
	private float facingright;
	void Start()
	{
		ani1 = GetComponent<Animator>();
		facingright = transform.localScale.x;
		rb2d = GetComponent<Rigidbody2D> ();

	}

	void Update(){

		moveHorizontal = Input.GetAxis ("Horizontal");
		moveVertical = Input.GetAxis ("Vertical");
		movement = new Vector2 (moveHorizontal, moveVertical);

		if(Input.GetButtonDown("Jump"))
		{
			jump = true;
			ani1.SetBool ("jumping", jump);
		}
		ani1.SetBool ("grounded", grounded);
		if (Input.GetAxis ("Horizontal") < -0.1f) {
			transform.localScale = new Vector2 (-facingright, transform.localScale.y);
		}
		if (Input.GetAxis ("Horizontal") > 0.1f) {
			transform.localScale = new Vector2 (facingright, transform.localScale.y);
		}

	}
		
	void FixedUpdate()
	{
		if (jump && grounded) {
			rb2d.AddForce (Vector2.up * jumpforce, ForceMode2D.Impulse);
			jump = false;
			ani1.SetBool ("jumping", jump);
		}
	
		if(moveHorizontal != 0)
		{
			rb2d.transform.Translate (movement * speed);
			ani1.SetBool ("walking", true);
		}
		else {
			ani1.SetBool ("walking", false);
		}
			


	}
}
