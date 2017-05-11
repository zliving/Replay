// tutorial credit goes to: https://www.studica.com/blog/create-ui-unity-tutorial

using UnityEngine;
using System.Collections;
using UnityEngine.UI; 	// We need this for calling UI scripts.
using UnityEngine.SceneManagement;		// We need this for scene changing.
using RAIN.Core;
using RAIN.Entities;

public class PauseManager : MonoBehaviour {
	[SerializeField]
	Transform UIPanel;	 	//We will assign our panel to this variable so we can enable/disable it.

	[SerializeField]
	Text timeText; 			//Will assign our Time Text to this variable so we can modify the text it displays.
	public bool isPaused; 		//Used to determine paused state
	AIRig barRig;
	AIRig ladyRig;
	AIRig customerRig;
	void Start() {
		UIPanel.gameObject.SetActive(false); 	// Pause menu is disabled when scene starts.
		isPaused = false; 		// isPaused is always false when our scene opens.
		rigUpAI();

	}

	void Update() {
		timeText.text = "Time Since Startup: " + Time.timeSinceLevelLoad; //Tells us the time since the scene loaded
		// If player presses escape and game is not paused...
		if ((Input.GetKeyDown(KeyCode.Escape) && (isPaused == false))) {
			// ...pause game.
			pause();
		}
		// If game is paused and player presses "esc"...
		else if (Input.GetKeyDown(KeyCode.Escape) && (isPaused == true)) {
			// ...unpause the game.
			unPause();
		}
	}

	// pause() pauses the game.
	public void pause() {
		UIPanel.gameObject.SetActive(true); //turn on the pause menu
		Time.timeScale = 0.0f; //pause the game
		// Free the cursor and make it visible.
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		isPaused = true;
	}

	// unPause() unpauses the game.
	public void unPause() {
		UIPanel.gameObject.SetActive(false); //turn off pause menu
		Time.timeScale = 1.0f; //resume game
		// Lock the cursor and hide it.
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		isPaused = false;
	}

	// quitGame() quits the game.
	//public void quitGame() {
	//	Application.Quit();
	//}

	// exitGame() goes back to the main menu.
	public void exitGame() {
		Time.timeScale = 1.0f; //resume game

		// Go back to the main menu.
		SceneManager.LoadScene (0);
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}

	// restart() loads the Base Scene again.
	public void restart() {
		// Load base scene again.
		SceneManager.LoadScene(2);

		// Resume the game once the scene has been loaded again.
		Time.timeScale = 1.0f;
		isPaused = false;
	}

	public bool getIsPaused(){
		return isPaused;
	}

	private void rigUpAI(){
		// Assign AI bodies again.
		barRig = GameObject.FindGameObjectWithTag ("AITag").GetComponentInChildren<AIRig> ();
		barRig.AI.Body = GameObject.FindGameObjectWithTag ("AITag");
		barRig.AI.Senses.GetSensor ("farSensor").MountPoint = GameObject.FindGameObjectWithTag ("AITag").transform;
		barRig.AI.Senses.GetSensor ("nearSensor").MountPoint = GameObject.FindGameObjectWithTag ("AITag").transform;
		GameObject.FindGameObjectWithTag ("AITag").GetComponentInChildren<EntityRig> ().Entity.Form = GameObject.FindGameObjectWithTag ("AITag");

		ladyRig = GameObject.FindGameObjectWithTag ("LadyTag").GetComponentInChildren<AIRig> ();
		ladyRig.AI.Body = GameObject.FindGameObjectWithTag ("LadyTag");

		customerRig = GameObject.FindGameObjectWithTag ("Customer").GetComponentInChildren<AIRig> ();
		customerRig.AI.Body = GameObject.FindGameObjectWithTag ("Customer");
		customerRig.AI.Senses.GetSensor ("visualSensor").MountPoint = GameObject.FindGameObjectWithTag ("Customer").transform;
		customerRig.AI.Senses.GetSensor ("nearSensor").MountPoint = GameObject.FindGameObjectWithTag ("Customer").transform;
		GameObject.FindGameObjectWithTag ("Customer").GetComponentInChildren<EntityRig> ().Entity.Form = GameObject.FindGameObjectWithTag ("Customer");

		GameObject.FindGameObjectWithTag ("CoffeeMachine").GetComponentInChildren<EntityRig> ().Entity.Form = GameObject.FindGameObjectWithTag ("CoffeeMachine");
	}
}