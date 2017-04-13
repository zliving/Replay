using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

    public GameObject draggingObject;
    public GameObject playerCamera;
    float distance = 1.5f;
    bool isDragging = false;

    float speed = 5;
    float maxSpeed = 15;
    private Transform dragObj = null;
    private RaycastHit hit;
    private float length;

    // Update is called once per frame 
    void Update() {

        if (Input.GetMouseButton(0))
        {  // if left mouse button pressed...
           // cast a ray from the mouse pointer
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (!dragObj)
            {  // if nothing picked yet...
               // and the ray hit some rigidbody...
                if (Physics.Raycast(ray, out hit) && hit.rigidbody)
                {
                    dragObj = hit.transform;  // save picked object's transform
                    length = hit.distance;  // get "distance from the mouse pointer"
                }
            }
            else
            {  // if some object was picked...
               // calc velocity necessary to follow the mouse pointer
                var vel = (ray.GetPoint(length) - dragObj.position) * speed;
                // limit max velocity to avoid pass through objects
                if (vel.magnitude > maxSpeed) vel *= maxSpeed / vel.magnitude;
                // set object velocity
                dragObj.GetComponent<Rigidbody>().velocity = vel;
            }
        }
        else
        {  // no mouse button pressed
            dragObj = null;  // dragObj free to drag another object
        }
    }

    private GameObject GetObjectFromMouseRaycast() {

        GameObject gmObj = null;
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

        if (hit) {

            if (hitInfo.collider.gameObject.GetComponent<Rigidbody>() && Vector3.Distance(hitInfo.collider.gameObject.transform.position,transform.position) <= distance) {
                gmObj = hitInfo.collider.gameObject;
            }
        }

        return gmObj;
    }

    private Vector3 CalculateMouse3DVector() {

        Vector3 mouseDrag = Input.mousePosition;
        mouseDrag.z = distance;
        mouseDrag = Camera.main.ScreenToWorldPoint(mouseDrag);

        return mouseDrag;
    }

    // OnMouseOver() is called when the mouse hovers over the GameObject collider
    public void OnMouseOver () {

        if (Input.GetKeyDown(KeyCode.E)) {
            // Disable the renderer and collider on the GameObject default child
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<Collider>().enabled = false;
        }
            
        // Send the pickupitem object data to the inventory
        GameObject.Find("GlobalScripts").GetComponent<TestInventory>().addItem(draggingObject);
    }
}

//if (Input.GetMouseButton(0)) {

//    if (!isDragging) {

//        draggingObject = GetObjectFromMouseRaycast();

//        if (draggingObject) {

//            //draggingObject.GetComponent<Rigidbody>().isKinematic = true;
//            isDragging = true;

//        }
//    }
//    else if (draggingObject != null) {

//        draggingObject.GetComponent<Rigidbody>().MovePosition(CalculateMouse3DVector());
//    }
//}
//else {

//    if (draggingObject != null) {

//        draggingObject.GetComponent<Rigidbody>().isKinematic = false;

//    }

//    isDragging = false;

//}

// OnMouseDrag() is called when the mouse clicks on the GameObject collider and continues to hold the mouse down
//public void OnMouseDrag() {
//    // Hold the item at a given distance from the camera while draging the user drags the mouse
//    Vector3 mouseDrag = Input.mousePosition;
//    mouseDrag.z = distance;
//    mouseDrag = Camera.main.ScreenToWorldPoint(mouseDrag);

//    this.gameObject.GetComponent<Rigidbody>().MovePosition(mouseDrag);
//}