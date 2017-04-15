using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic; 
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO;

public class SaveLoad : MonoBehaviour {
	public static SaveLoad saveLoad;
	// The object, "savedGames" is the list of games that have been saved.
	public static List<Game> savedGames = new List<Game>();

	public void Save() {
		// Append the current "Game" object to the list of saved games.
		savedGames.Add(Game.current);
		// Handles serialization work.
		BinaryFormatter bf = new BinaryFormatter();
		// Creates a filestream and a file object and passes it to the "saved games.gd location where savedGames is the
		// name of the location and .gd is the file type of the file location.
		FileStream file = File.Create (Application.persistentDataPath + "/savedGames.gd");	
		// Uses the Binary Formatter to create the file location as input.
		bf.Serialize(file, SaveLoad.savedGames);
		// Close the file.
		file.Close();
	}

	public void Load() {
		// Checks if the game to load exists.
		if(File.Exists(Application.persistentDataPath + "/savedGames.gd")) {
			// Handles serialization work.
			BinaryFormatter bf = new BinaryFormatter();
			// Create a file stream as well as a "Game Data" file and open it.
			FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
			// Save the file by adding the non-binary version into the list of saved files.
			SaveLoad.savedGames = (List<Game>)bf.Deserialize(file);
			// Close the file.
			file.Close();
		}
	}
}