using System.Collections;
using UnityEngine;

public class MouseHover : MonoBehaviour {

	void Start () {
		GetComponent<Renderer>().material.color = Color.cyan;
	}

	void OnMouseEnter() {
		GetComponent<Renderer>().material.color = Color.cyan;
	}

	void OnMouseExit() {
		GetComponent<Renderer>().material.color = Color.cyan;
	}
}
