using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManage : MonoBehaviour {

	public AudioSource source;
	public AudioSource musicSource;
	public static SoundManage instance = null;
	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
		} 
		else if (instance != this) {
			Destroy (gameObject);

			DontDestroyOnLoad (gameObject);
		}
	}

	public void PlaySingle (AudioClip clip) {
		source.clip = clip;
		source.Play ();

	}





}