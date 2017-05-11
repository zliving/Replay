using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RAIN.Core;
public class OfCourseSound : MonoBehaviour {
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

	private IEnumerator wait(float secs){
		Debug.Log ("Entered wait");
		yield return new WaitForSeconds (secs);
		Debug.Log ("Exited wait");

	}

	void OnTriggerEnter(){
		Debug.Log ("Entered of course trigger");
		if (ai.getBoolean ("timeUp") && ai.getBoolean ("customerOrdered") && !alreadyPlayed) {
			source.PlayOneShot (clip, volume);
			StartCoroutine (wait (20.0f));
			alreadyPlayed = true;
			Debug.Log ("Played of course");
		}
	}
}
