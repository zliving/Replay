using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInventory : MonoBehaviour {

    List<GameObject> inventory = new List<GameObject>();

    // addItem() is called from itemPickup.cs and is passed the object being picked up
    public void addItem(GameObject pickup) {
        // Add the picked up item to the inventory
        inventory.Add(pickup);  
    }

    // removeItem() is called from itemPutback.cs and is passed the object being put back
    public void removeItem(GameObject putback) {
        // Find the putback item in the inventory
        for(int i = 0; i < inventory.Count - 1; i++) {
            if (inventory[i] == putback) {
                // Remove the putback item from the inventory
                inventory.Remove(inventory[i]);
            }
        }    
    }
}
