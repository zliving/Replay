using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPutback : MonoBehaviour {

    public GameObject putbackText;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // OnMouseOver() is called once per frame while the mouse is over the object
    void OnMouseOver () {
        // Change Overlay text to show a message
        putbackText.GetComponent<Text>().enabled = true;
        putbackText.GetComponent<Text>().text = "Put back the " + this.name;
    }

    // OnMouseExit() is called after following OnMouseOver()
    void OnMouseExit() {
        // Disable the putbackText from showing on the screen
        putbackText.GetComponent<Text>().enabled = false;   
    }

    // OnMouseClick is called when the mouse clicks the GameObject
    void OnMouseClick () {
        // Enable the renderer and collider
        this.GetComponent<MeshRenderer>().enabled = true;  
        this.GetComponent<Collider>().enabled = true;  

        // Remove the item from the inventory

    }
}
