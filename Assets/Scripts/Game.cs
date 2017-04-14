/*
 * This script is intended for practice with Unity's save and load features
 */

using UnityEngine;
using System.Collections;

[System.Serializable]		// Allows the data created by this script to be saved and loaded.
public class Game { 
	public static Game current;
	public Character knight;
	public Character rogue;
	public Character wizard;

	public Game () {
		knight = new Character();
		rogue = new Character();
		wizard = new Character();
	}

}