using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuMuisc : MonoBehaviour {

	static bool AudioBegin = false;
	public AudioSource audio;

	void Awake() {
		if (!AudioBegin) {
			audio.Play();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		} 
	}

	void Update () {
		if(Application.loadedLevelName == "Base Scene")
		{
			audio.Stop();
			AudioBegin = false;
		}
	}
}
