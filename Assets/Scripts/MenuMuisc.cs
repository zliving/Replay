// Solution on resuming the audio during load credit to:
// http://answers.unity3d.com/questions/878382/audio-or-music-to-continue-playing-between-scene.html?childToView=878393#answer-878393

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuMuisc : MonoBehaviour {
	static bool AudioBegin = false;
	public AudioSource audio;

	void Awake() {
		if (!AudioBegin) {
			// Begin playing the audio file when the main menu loads up.
			audio.Play();
			// Keep playing the audio file during the loading screen.
			DontDestroyOnLoad(gameObject);
			AudioBegin = true;
		} 
	}

	void Update () {
		// If the Base Scene has been loaded...
		if(Application.loadedLevelName == "Base Scene") {
			// ...stop the music.
			audio.Stop();
			AudioBegin = false;
		}
	}
}
