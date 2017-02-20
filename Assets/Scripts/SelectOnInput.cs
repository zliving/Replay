// Credit goes to: https://unity3d.com/learn/tutorials/topics/user-interface-ui/creating-main-menu

using UnityEngine;
using System.Collections;
using Unity.EventSystems;

public class SelectOnInput : MonoBehaviour {
	public EventSystem evenSystem;
	public GameObject selectedObject;
	private bool buttonSelected;

	// Use this for initialization.
	void Start() {}

	// Update is called once per frame.
	void Update() {
		if (Input.GetAxisRaw("Vertical") != 0 && buttonSelected == fase) {
			eventSystem.SetSelectedGameObject(selectedObject);
			buttonSelected = true;
		}
	}

	private void OnDisable(){
		buttonSelected = false;
	}
}
