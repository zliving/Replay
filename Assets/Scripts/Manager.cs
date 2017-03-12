// tutorial credit goes to: https://www.studica.com/blog/create-ui-unity-tutorial

using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Need this for calling UI scripts

public class Manager : MonoBehaviour {
	[SerializeField]
	Transform UIPanel; //Will assign our panel to this variable so we can enable/disable it

	[SerializeField]
	Text timeText; //Will assign our Time Text to this variable so we can modify the text it displays.
	bool isPaused; //Used to determine paused state

	void Start() {
		UIPanel.gameObject.SetActive(false); // Pause menu is disabled when scene starts
		isPaused = false; // isPaused is always false when our scene opens
	}

	void Update() {
		timeText.text = "Time Since Startup: " + Time.timeSinceLevelLoad; //Tells us the time since the scene loaded
		// If player presses "p" and game is not paused...
		if (Input.GetKeyDown(KeyCode.P) && (isPaused == false)) {
			// pause game.
			pause();
		}
		// If game is paused and player presses "p"...
		else if (Input.GetKeyDown(KeyCode.P) && (isPaused == true)) {
			// ...unpause the game.
			unPause();
		}
	}

	// pause() pauses the game.
	public void pause() {
		UIPanel.gameObject.SetActive(true); //turn on the pause menu
		Time.timeScale = 0.0f; //pause the game
		isPaused = true;
	}

	// unPause() unpauses the game.
	public void unPause() {
		UIPanel.gameObject.SetActive(false); //turn off pause menu
		Time.timeScale = 1.0f; //resume game
		isPaused = false;
	}

	// quitGame() goes back to the main menu.
	public void quitGame() {
		Application.LoadLevel(0); 
	}

	// restart() loads the Base Scene again.
	public void restart() {
		Application.LoadLevel(2);
	}
}