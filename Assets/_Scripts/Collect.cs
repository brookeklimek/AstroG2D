using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {

	public int points;
	public AudioClip collect;


	void OnTriggerEnter2D (Collider2D other) {
		SoundManage.instance.PlaySingle (collect);
		GameManager.AddScore (points);

		StartCoroutine(DelayedLoad());
	}

	IEnumerator DelayedLoad() {
		//Play the clip once


		//Wait until clip finish playing
		yield return new WaitForSeconds(collect.length);   

		//Load scene here
		Object.Destroy (gameObject);

	}


}
