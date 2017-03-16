using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPutback : MonoBehaviour {

    public GameObject putbackText;
    public GameObject defaultChild;
    public GameObject gameObject;

    // OnMouseOver() is called once per frame while the mouse is over the GameObject
    void OnMouseOver () {
        // Continue to the following code only if the item has already been picked up
        if (defaultChild.GetComponent<Collider>().enabled == false) {
            // Change the GUI overlay text to show a message for putting the item back
            putbackText.GetComponent<Text>().enabled = true;
            putbackText.GetComponent<Text>().text = "Put back the " + this.name;

            // If the mouse clicks where the item belongs, while it is not there, execute the following code
            if (Input.GetMouseButtonDown(0)) {
                // Enable the renderer and collider on the GameObject default child
                defaultChild.GetComponent<MeshRenderer>().enabled = true;
                defaultChild.GetComponent<Collider>().enabled = true;

                // Remove the putback item from the inventory
                GameObject.Find("GlobalScripts").GetComponent<TestInventory>().removeItem(gameObject);
            }
        }
    }

    // OnMouseExit() is called after exiting OnMouseOver()
    void OnMouseExit() {
        // Disable the putbackText from showing on the screen
        putbackText.GetComponent<Text>().enabled = false;   
    }
}
