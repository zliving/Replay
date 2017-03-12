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
		// If player presses escape and game is not paused...
		if(Input.GetKeyDown(KeyCode.P) && !isPaused)
			// pause game.
			pause();
		// TODO: instead of using the escape key, change it to the "p" key
		// If game is paused and player presses escape...
		else if(Input.GetKeyDown(KeyCode.P) && isPaused)
			// ...unpause the game.
			unPause();
	}

	// Pause pauses the game.
	public void pause() {
		isPaused = true;
		UIPanel.gameObject.SetActive(true); //turn on the pause menu
		Time.timeScale = 0f; //pause the game
	}

	public void unPause() {
		isPaused = false;
		UIPanel.gameObject.SetActive(false); //turn off pause menu
		Time.timeScale = 1f; //resume game
	}

	public void quitGame() {
		Application.Quit(); // Only works for desktop application of the game.
	}

	// restart() goes back to the main menu.
	public void restart() {
		Application.LoadLevel(0);
	}
}