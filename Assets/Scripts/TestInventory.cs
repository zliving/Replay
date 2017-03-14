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

    //addItem is called from itemPickup and passes the object being picked up
    public void addItem(GameObject pickup) {
        inventory.Add(pickup);  //Add the picked up item to the inventory

        //for debug purposes show names of GameObjects in Inventory
        foreach (var item in inventory) {
            Debug.Log(item.name);
        }
    }

    //removeItem is called from itemPutdown and passes the object being put down
    /*public void removeItem(GameObject putdown) {
        for(int i = 0; i < inventory.Count - 1; i++) {
            if (inventory[i] == putdown) {
                inventory.Remove(i);
            }
        }    
    }*/
}
