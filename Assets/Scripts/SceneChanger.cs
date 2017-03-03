// tutorial credit: https://www.youtube.com/watch?v=TEq4P0kDAtE&feature=youtu.be

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	public void changeToScene(int sceneToChangeTo) {
		SceneManager.LoadScene (sceneToChangeTo);
	}
}
