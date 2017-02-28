using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
	public bool isStart;
	public bool isQuit;

	void OnMouseUp() {
		if (isStart) {
			Application.LoadLevel(0);
		}if (isQuit) {
			// Application.Quit() only works when the game is launched as a desktop application...
			Application.Quit();
			// so the exit button's will change to green as a way of testing it in Unity.
			GetComponent<Renderer>().material.color = Color.green;
		}
	}
}