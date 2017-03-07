using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RAIN.Core;

public class CounterTrigger : MonoBehaviour, ITrigger {
	public TriggerController controller;
	private string objectTag = "PlayerTag";

	private void OnEnable(){
		Debug.Log("Enabled");
		controller.setTriggerInterface(this);
	}

	public void OnTriggerEnter(Collider c){
		Debug.Log("Entered");
		controller.OnTriggerEnter (c);
	}

	public void OnTriggerExit(Collider c){
		controller.OnTriggerExit (c);
	}

	public void Enter(Collider c, ref bool onTrigger){
		Debug.Log (this.tag);
		if (c.tag == objectTag) {
			Debug.Log ("tag match");
			onTrigger = true;
			GameObject go = GameObject.FindGameObjectWithTag ("AITag");
			AIRig rig = go.GetComponentInChildren<AIRig> ();
			rig.AI.WorkingMemory.SetItem<bool> ("triggered", true);
		}
	}

	public void Exit(Collider c, ref bool onTrigger){
		if (c.tag == objectTag) {
			onTrigger = false;
			GameObject go = GameObject.FindGameObjectWithTag ("AITag");
			AIRig rig = go.GetComponentInChildren<AIRig> ();
			rig.AI.WorkingMemory.SetItem<bool> ("triggered", false);
		}
	}

	public void setObjectTag(string str){
		objectTag = str;
	}

}
