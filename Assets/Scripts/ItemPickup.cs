using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

    public GameObject itemParent;
    float distance = 1.5f;

    // OnMouseDown() is called when the mouse clicks on the GameObject collider
    public void OnMouseOver () {

        if (Input.GetKeyDown(KeyCode.E))
        {
            // Disable the renderer and collider on the GameObject default child
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<Collider>().enabled = false;
        }
            

        // Send the pickupitem object data to the inventory
        GameObject.Find("GlobalScripts").GetComponent<TestInventory>().addItem(itemParent);

    }

    // OnMouseDrag() is called when the mouse clicks on the GameObject collider and continues to hold the mouse down
    public void OnMouseDrag()
    {
        // Set hold the item at a given distance from the camera while draging the user drags the mouse
        Vector3 mouseDrag = Input.mousePosition;
        mouseDrag.z = distance;
        mouseDrag = Camera.main.ScreenToWorldPoint(mouseDrag);

        this.gameObject.GetComponent<Rigidbody>().MovePosition(mouseDrag);
    }
}
