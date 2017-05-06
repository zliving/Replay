using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cellphone_ring : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {

		// If the left mouse button is pressed down
		if (Input.GetMouseButtonDown (0) == true) {
			GetComponent<AudioSource> ().Play ();
		}
		// If the left mouse button is realeased
		if (Input.GetMouseButtonUp (0) == true) {
			GetComponent<AudioSource> ().Stop ();
		}
	}
}
