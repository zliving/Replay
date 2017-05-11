using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC.TimeOfDaySystemFree;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private DisplayTime getTime = null;
	private string time = null;

	// Use this for initialization
	void Start () {
		getTime =  GetComponent<DisplayTime> ();
		time = getTime.GetTimeString ();
	}
	
	// Update is called once per frame
	void Update () {
		time = getTime.GetTimeString ();
		if(time == "24:00") {
			// Load base scene again.
			SceneManager.LoadScene(2);
			// Resume the game once the scene has been loaded again.
			Time.timeScale = 1.0f;
		}
	}
}
