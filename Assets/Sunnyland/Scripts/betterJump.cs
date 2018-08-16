using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betterJump : MonoBehaviour {


	public float fallmultiplier = 2.5f;
	public float Lowjumpmultiplier = 2f;

	Rigidbody2D rb2d;

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	

	void FixedUpdate () {
		if (rb2d.velocity.y < 0) {
			rb2d.gravityScale = fallmultiplier;
		}
		else if (rb2d.velocity.y > 0 && Input.GetButtonDown("Jump")) {
			rb2d.gravityScale = Lowjumpmultiplier;
		}
		else{
			rb2d.gravityScale = 1f;
		}
	}
}
