using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInventory : MonoBehaviour {

    List<GameObject> inventory = new List<GameObject>();

    // Use this for initialization
    void Start () {
          
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // addItem() is called from itemPickup and passes the object being picked up
    public void addItem(GameObject pickup) {
        // Add the picked up item to the inventory
        inventory.Add(pickup);  
    }

    // removeItem() is called from itemPutdown and passes the object being put back
    public void removeItem(GameObject putback) {
        // Find the putback item in the inventory
        for(int i = 0; i < inventory.Count - 1; i++) {
            if (inventory[i] == putback) {
                // Remove the item being put back
                inventory.Remove(inventory[i]);
            }
        }    
    }
}
