using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

    public GameObject CupDefault;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown () {
        //gameObject.SetActive (false);
        CupDefault.GetComponent<MeshRenderer>().enabled = false;
	}
}
