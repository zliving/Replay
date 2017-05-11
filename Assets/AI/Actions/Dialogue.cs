using System;
using System.Collections;
using RAIN.Core;
using UnityEngine;

public class Dialogue
{
	protected AudioSource source;
	protected AudioClip clip;
	public Dialogue(RAIN.Core.AI ai, String path){
		source = ai.Body.GetComponent<AudioSource> ();
		clip = (AudioClip)Resources.Load (path);
		source.clip = clip;
	}
		
	public void play(){
		source.Play ();
	}
}


