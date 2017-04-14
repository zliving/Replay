/*
 * This script is intended for practice with Unity's save and load features
 */

using UnityEngine;
using System.Collections;

[System.Serializable] 		// Allows the data created by this script to be saved and loaded.
public class Character {
	public string name;

	public Character () {
		this.name = "";
	}
}