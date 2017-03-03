using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour {
	// Use a boolean to specify that a new scene is not loading.
	private bool loadScene = false;
	[SerializeField]
	private int scene;
	[SerializeField]
	private Text loadingText;

	void Update() {
		// If a new scene is not loading...
		if (loadScene == false) {
			// ...set the loadScene boolean to true to prevent loading a new scene more than once...
			loadScene = true;
			// ...change the instruction text to read "Loading"
			loadingText.text = "Loading";
			// ...and start a coroutine that will load the desired scene.
			StartCoroutine(LoadNewScene());
		} // If the new scene has started loading...
		else {
			// ...then pulse the transparency of the loading text
			// TODO: customize the animation to either the replay text pulsing or the circular arrow rotating.
			loadingText.color = new Color(loadingText.color.r, loadingText.color.g, loadingText.color.b, 
				Mathf.PingPong(Time.time, 1));
		}
	}

	// The coroutine runs on its own at the same time as Update() and takes an integer indicating which scene to load.
	IEnumerator LoadNewScene() {
		// This line waits for 3 seconds before executing the next line in the coroutine.
		yield return new WaitForSeconds(3);
		// Start an asynchronous operation to load the scene that was passed to the LoadNewScene coroutine.
		// The integer represents the scene being loaded.
		// TODO: Once we assign the number 2 to the gameplay scene in the build settings, change 1 with 2.
		AsyncOperation async = Application.LoadLevelAsync(0);		
		// While the asynchronous operation to load the new scene is not yet complete, continue waiting until it's done.
		while (!async.isDone) {
			yield return null;
		}
	}
}