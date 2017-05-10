using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RAIN.Core;
using RAIN.Navigation;
using RAIN.Navigation.Waypoints;
using RAIN.BehaviorTrees;
public class AIScript : MonoBehaviour {
	private GameObject player;
	private AIRig rig;
	private float time;
	private float customerOrderDelay = 2.0f;
	private float coffeeDelay = 3.0f;
	// [System.Serializable]
	// public class EventBooleans{
	// 	public string boolName;
	// 	public bool b;
	// }

	// [SerializeField]
	// private List<EventBooleans> ;

	// Use this for initialization
	void Start () {
		rig = GetComponentInChildren<AIRig> ();
		rig.AI.WorkingMemory.SetItem<float>("timeline", 6.0f);
		rig.AI.WorkingMemory.SetItem<bool> ("isClosingTime", false);
		rig.AI.WorkingMemory.SetItem<bool> ("converseWithPlayer", false);
		rig.AI.WorkingMemory.SetItem<bool> ("customerOrdered", false);
		rig.AI.WorkingMemory.SetItem<bool> ("makeCoffee", false);
		rig.AI.WorkingMemory.SetItem<bool> ("timeUp", false);
//		mainRoute = NavigationManager.Instance.GetWaypointSet ("Waypoint Route");
//		otherRoute = NavigationManager.Instance.GetWaypointSet ("OtherRoute");
//		rig.AI.WorkingMemory.SetItem<WaypointSet> ("_route", mainRoute);
//		Debug.Log(rig.AI.WorkingMemory.GetItem<GameObject>("_route").ToString());
	}
	
	// Update is called once per frame
	void Update () {
		updateTriggered();
		updateCupAvailable ();
		updateClosingTime ();
		updateCustomerOrdered ();
	}

	private void updateTriggered(){
		if (isTrue("triggered")) {
			changeRoute ("CafeRoute");
		} else if(isFalse("triggered")){
			changeRoute ("CounterRoute");
		}
	}

	private void updateCoffeeMade(){
		if (rig.AI.WorkingMemory.GetItem<bool> ("makeCoffee")) {
			if (timeUp (coffeeDelay)) {
				rig.AI.WorkingMemory.SetItem<bool> ("timeUp", true);
			} else {
				time += Time.deltaTime;
			}
		}
	}

	private void updateCustomerOrdered(){
		if (rig.AI.WorkingMemory.GetItem<bool> ("customerOrdered")) {
			if (timeUp (customerOrderDelay)) {
				rig.AI.WorkingMemory.SetItem<bool> ("timeUp", true);
			} else {
				time += Time.deltaTime;
			}
		}
	}

	private bool timeUp(float delay){
		return time >= delay; 
	}

	private void updateClosingTime(){
		if (rig.AI.WorkingMemory.GetItem<float>("timeline") >= 23.0f) {
			rig.AI.WorkingMemory.SetItem<bool> ("isClosingTime", true);
		}
	}

	private void updateCupAvailable () {
		GameObject cup = GameObject.FindGameObjectWithTag ("CoffeeCup");

		if (cup.GetComponent<MeshRenderer>().enabled) {
			rig.AI.WorkingMemory.SetItem<bool> ("isCupAvailable", true);
		} else {
			rig.AI.WorkingMemory.SetItem<bool> ("isCupAvailable", false);
		}
	}

	public void changeRoute (string route){
		rig.AI.WorkingMemory.SetItem<string> ("route", route);
		rig.AI.Navigator.RestartPathfindingSearch ();
	}

	private bool isTrue (string memoryVariableName){
		return rig.AI.WorkingMemory.GetItem<bool> (memoryVariableName);
	}

	private bool isFalse (string memoryVariableName){
		return !rig.AI.WorkingMemory.GetItem<bool> (memoryVariableName);
	}

	public bool getBoolean(string name){
		return rig.AI.WorkingMemory.GetItem<bool> (name);
	}

	public void setBoolean(string name, bool b){
		rig.AI.WorkingMemory.SetItem<bool> (name, b);
	}


}
