using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {
	
	public AudioClip levelUp;



	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			SoundManage.instance.PlaySingle (levelUp);
			//GameManager.NextLevel ();
			StartCoroutine(DelayedLoad());

		}
	}

	IEnumerator DelayedLoad() {
		
		//Wait until clip finish playing
		yield return new WaitForSeconds (levelUp.length);    

		//Load scene here
		GameManager.NextLevel ();

	}
}
