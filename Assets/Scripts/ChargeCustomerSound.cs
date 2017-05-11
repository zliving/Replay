using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeCustomerSound : MonoBehaviour {
	private AudioClip clip;
	private float volume;
	private AudioSource source;
	private bool alreadyPlayed = false;
	private AIScript ai;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
		clip = source.clip;
		volume = source.volume;
		ai = GameObject.FindGameObjectWithTag ("AITag").GetComponent<AIScript> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(){
		Debug.Log ("Entered charge customer trigger");
		if (ai.getBoolean ("makeCoffee") && !alreadyPlayed) {
			source.PlayOneShot (clip, volume);
			alreadyPlayed = true;
		}
	}
		
}
