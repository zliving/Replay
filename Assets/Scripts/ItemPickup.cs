using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

    public GameObject itemParent;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // OnMouseDown() is called when the mouse clicks on the GameObject collider
	void OnMouseDown () {
        // Disable the renderer and collider
        this.GetComponent<MeshRenderer>().enabled = false;
		this.GetComponent<Collider>().enabled = false;

        // Send the pickup object data to the inventory
        GameObject.Find("GlobalScripts").GetComponent<TestInventory>().addItem(itemParent);

    }
}
