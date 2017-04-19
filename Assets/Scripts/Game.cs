using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using AC.TimeOfDaySystemFree;

[System.Serializable]		// Allows the data created by this script to be saved and loaded.
public class Game : MonoBehaviour{ 
	public static Game current;
	public string time;
	private TimeOfDayManager timeManager = null;
	public float  Hour{ get; private set; }
	public float  Minute{ get; private set; }
	public float timeline = 7f;

	public Game () {
		// Anything that we want to save will go in here.

		// Get the time.

		// Get hour and minutes.
		//Hour   = Mathf.Floor (timeline);
		//Minute = Mathf.Floor ((timeline - Hour)*60);
		//timeManager = GetComponent<TimeOfDayManager> ();
		//Get the time from DisplayTime.cs
		//time = DisplayTime.GetTimeString();
	}
}