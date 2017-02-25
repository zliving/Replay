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
			Application.Quit();
			GetComponent<Renderer>().material.color = Color.green;
		}
	}
}