using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	void Update() {
		// X axis
		if (transform.position.x <= -8.55f) {
			transform.position = new Vector2(-8.55f, transform.position.y);
		} else if (transform.position.x >= 8.55f) {
			transform.position = new Vector2(8.55f, transform.position.y);
		}
			
	}

}
