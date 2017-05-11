using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
	private AudioClip clip;
	private float volume;
	private AudioSource source;
	private bool alreadyPlayed = false;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
		clip = source.clip;
		volume = source.volume;
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider c) {
		Debug.Log ("Trigger entered");
		if (!alreadyPlayed) {
			Debug.Log ("Playing");
			source.PlayOneShot (clip, volume);
			alreadyPlayed = true;
		}
	}
}
