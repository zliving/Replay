using System;
using System.Collections;
using RAIN.Core;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
	protected AudioSource source;
	protected AudioClip clip;
	public Dialogue(RAIN.Core.AI ai, String path){
		source = ai.Body.GetComponent<AudioSource> ();
		clip = (AudioClip)Resources.Load (path);
		source.clip = clip;
	}

	public void wait(float seconds){
		StartCoroutine (waitEnum (seconds));
	}

	private IEnumerator waitEnum(float seconds){
		yield return new WaitForSeconds (seconds);
	}
		
	public void play(){
		source.Play ();
	}
}


