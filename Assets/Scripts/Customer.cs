using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RAIN.Core;
using RAIN.Navigation;
using RAIN.Navigation.Waypoints;
using RAIN.BehaviorTrees;
public class Customer : MonoBehaviour {
	private GameObject player;
	private AIRig rig;
	private Animator anim;

	// Use this for initialization
	void Start () {

		rig = GetComponentInChildren<AIRig> ();
		anim = GetComponent<Animator> ();
		anim.SetInteger ("state", 1);
		rig.AI.WorkingMemory.SetItem<bool> ("converseWithPlayer", false);
		rig.AI.WorkingMemory.SetItem<bool> ("missingScriptBook", false);
		rig.AI.WorkingMemory.SetItem<bool> ("missingAllBooks", false);
		//		mainRoute = NavigationManager.Instance.GetWaypointSet ("Waypoint Route");
		//		otherRoute = NavigationManager.Instance.GetWaypointSet ("OtherRoute");
		//		rig.AI.WorkingMemory.SetItem<WaypointSet> ("_route", mainRoute);
		//		Debug.Log(rig.AI.WorkingMemory.GetItem<GameObject>("_route").ToString());
	}

	// Update is called once per frame
	void Update () {
		// Add updateforBools
	}

	private bool isTrue (string memoryVariableName){
		return rig.AI.WorkingMemory.GetItem<bool> (memoryVariableName);
	}

	private bool isFalse (string memoryVariableName){
		return !rig.AI.WorkingMemory.GetItem<bool> (memoryVariableName);
	}

	private bool getBoolean(string name){
		return rig.AI.WorkingMemory.GetItem<bool> (name);
	}

	private bool isNotNull (string name) {
		return rig.AI.WorkingMemory.GetItem<GameObject> (name) != null;
	}
}
