using UnityEngine;
using System.Collections;
using AC.TimeOfDaySystemFree;

[System.Serializable]		// Allows the data created by this script to be saved and loaded.
public class Game { 
	public static Game current;
	public string time;

	public Game () {
		// Anything that we want to save will go in here.

		//Get the time from DisplayTime.cs
		//time = DisplayTime.GetTimeString();
	}
}