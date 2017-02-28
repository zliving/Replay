// tutorial credit goes to : http://www.instructables.com/id/How-to-make-a-main-menu-in-Unity/

using System.Collections;
using UnityEngine;

public class MouseHover : MonoBehaviour {
	void Start () {
		GetComponent<Renderer>().material.color = Color.cyan;
	}

	void OnMouseEnter() {
		GetComponent<Renderer>().material.color = Color.red;
	}

	void OnMouseExit() {
		GetComponent<Renderer>().material.color = Color.cyan;
	}
}