// Credit goes to: https://unity3d.com/learn/tutorials/topics/user-interface-ui/creating-main-menu

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {
	public void LoadByIndex(int sceneIndex){
		SceneManager.LoadScene(sceneIndex);
	}
}