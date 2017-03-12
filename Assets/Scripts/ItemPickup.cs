using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown () {
        this.GetComponent<MeshRenderer>().enabled = false;		//Disables renderer on click
		this.GetComponent<Collider>().enabled = false;	//Disables collider on click
	}
}
