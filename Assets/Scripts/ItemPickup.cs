using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

    public GameObject itemParent;

    // OnMouseDown() is called when the mouse clicks on the GameObject collider
	public void OnMouseDown () {
        // Disable the renderer and collider on the GameObject default child
        this.GetComponent<MeshRenderer>().enabled = false;
		this.GetComponent<Collider>().enabled = false;

        // Send the pickupitem object data to the inventory
        GameObject.Find("GlobalScripts").GetComponent<TestInventory>().addItem(itemParent);

    }
}
