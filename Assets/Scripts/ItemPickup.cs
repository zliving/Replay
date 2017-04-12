using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

    public GameObject itemParent;
    float distance = 1.5f;
    bool isDragging = false;

    // Update is called once per frame
    void Update() {

        if (Input.GetMouseButton(0)) {

            if (!isDragging) {

                itemParent = GetObjectFromMouseRaycast();

                if (itemParent) {

                    itemParent.GetComponent<Rigidbody>().isKinematic = true;
                    isDragging = true;

                }
            }
            else if (itemParent != null) {

                itemParent.GetComponent<Rigidbody>().MovePosition(CalculateMouse3DVector());

            }
        }
        else {

            if (itemParent != null) {

                itemParent.GetComponent<Rigidbody>().isKinematic = false;

            }

            isDragging = false;

        }
    }

    private GameObject GetObjectFromMouseRaycast() {

        GameObject gmObj = null;
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

        if (hit) {

            if (hitInfo.collider.gameObject.GetComponent<Rigidbody>() &&
                Vector3.Distance(hitInfo.collider.gameObject.transform.position,
                transform.position) <= distance)
            {
                gmObj = hitInfo.collider.gameObject;
            }
        }

        return gmObj;

    }

    private Vector3 CalculateMouse3DVector()
    {

        Vector3 mouseDrag = Input.mousePosition;
        mouseDrag.z = distance;
        mouseDrag = Camera.main.ScreenToWorldPoint(mouseDrag);

        return mouseDrag;
    }

    // OnMouseDown() is called when the mouse clicks on the GameObject collider
    public void OnMouseOver () {

        if (Input.GetKeyDown(KeyCode.E)) {
            // Disable the renderer and collider on the GameObject default child
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<Collider>().enabled = false;
        }
            
        // Send the pickupitem object data to the inventory
        GameObject.Find("GlobalScripts").GetComponent<TestInventory>().addItem(itemParent);
    }

    // OnMouseDrag() is called when the mouse clicks on the GameObject collider and continues to hold the mouse down
    //public void OnMouseDrag() {
    //    // Hold the item at a given distance from the camera while draging the user drags the mouse
    //    Vector3 mouseDrag = Input.mousePosition;
    //    mouseDrag.z = distance;
    //    mouseDrag = Camera.main.ScreenToWorldPoint(mouseDrag);

    //    this.gameObject.GetComponent<Rigidbody>().MovePosition(mouseDrag);
    //}
}
