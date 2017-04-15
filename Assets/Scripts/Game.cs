/*
 * This script is intended for practice with Unity's save and load features
 */

using UnityEngine;
using System.Collections;
using AC.TimeOfDaySystemFree;

[System.Serializable]		// Allows the data created by this script to be saved and loaded.
public class Game { 
	public static Game current;
	public string time;

	public Game () {
		//Get the time from DisplayTime.cs
		//time = DisplayTime.GetTimeString();
	}

}