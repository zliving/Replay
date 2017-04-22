using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

    float speed = 5;
    float maxSpeed = 15;
    private Transform dragObj = null;
    private RaycastHit hit;
    private float length;

    // Update is called once per frame 
    void Update() {
        // Check if the mouse button is being pressed
        if (Input.GetMouseButton(0)) {  
            // Cast a ray from the FPS camera to the item
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // No item is currently being dragged
            if (!dragObj) { 
                // Check for a RaycastHit on an item
                if (Physics.Raycast(ray, out hit) && hit.rigidbody) {
                    // Store the previous location of the item
                    dragObj = hit.transform;
                    // Store the distance between the item and the mouse
                    length = hit.distance;  
                }
            }
            else {
                // Determine the velocity needed to move the item smoothly
                var vel = (ray.GetPoint(length) - dragObj.position) * speed;
                // Limit the velocity to prevent collisions
                if (vel.magnitude > maxSpeed) vel *= maxSpeed / vel.magnitude;
                // Set the velocity of the item being dragged
                dragObj.GetComponent<Rigidbody>().velocity = vel;
            }
        }
        else {
            // Reset dragObj so a new item can be selected
            dragObj = null;  
        }

        // Check if the "E" key is being pressed
        if (Input.GetKeyDown(KeyCode.E)) {
            // Cast a ray from the FPS camera to the item
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Check for a RaycastHit on an item
            if (Physics.Raycast(ray, out hit) && hit.rigidbody) {
                // Disable the renderer and collider on the GameObject default child
                hit.collider.gameObject.GetComponent<MeshRenderer>().enabled = false;
                hit.collider.gameObject.GetComponent<Collider>().enabled = false;
                // Send the pickupitem object data to the inventory
                GameObject.Find("GlobalScripts").GetComponent<TestInventory>().addItem(hit.collider.gameObject.name);
            }
        }
    }
}