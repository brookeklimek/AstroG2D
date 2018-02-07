using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {


	public static bool triggered;

	private Animator anim; 


	void Start () {
		anim = GetComponent <Animator> ();
		triggered = false;
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.CompareTag ("Player")) {
			anim.SetTrigger ("Pull");
			triggered = true;

		}
	}
		
}
