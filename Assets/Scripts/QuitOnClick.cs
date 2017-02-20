// Credit goes to: https://unity3d.com/learn/tutorials/topics/user-interface-ui/creating-main-menu

using UnityEngine;
using System.Collections;

public class QuitOnClick : MonoBehaviour {
	public void Quit(){
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}