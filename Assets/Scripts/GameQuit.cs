using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameQuit : MonoBehaviour {

	public void Update() {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		}
	}

	public void QuitOnClick(bool isClicked) {
		// Application.Quit() only works when the game is launched as a desktop application...
		Application.Quit();
		// Unlike in the previous GUI I can't change the color on a button.
	}
		
}
