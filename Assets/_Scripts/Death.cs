using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	public AudioClip death;


	void OnCollisionEnter2D (Collision2D other) {

		if (other.gameObject.tag == "Player") {
			SoundManage.instance.PlaySingle (death);
			GameManager.Death ();

			//StartCoroutine(DelayedLoad());

		}
		else {
			Object.Destroy (other.gameObject);
		}
	}

//	IEnumerator DelayedLoad() {
//		
//		//Wait until clip finish playing
//		yield return new WaitForSeconds(death.length);   
//
//		//Load scene here
//		GameManager.Death ();
//
//	}

}
