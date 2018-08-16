using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundcheck : MonoBehaviour {

	private PlayerController player;

	void Start()
	{
		player = GetComponentInParent<PlayerController> ();
	}

	void OnTriggerEnter2D(Collider2D cal){
		player.grounded = true;
	}

	void OnTriggerExit2D(Collider2D cal){
		player.grounded = false;
	}
}