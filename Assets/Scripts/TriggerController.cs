using System;
using UnityEngine;

[Serializable]
public class TriggerController {
	private bool playerOnTrigger = false;

	private ITrigger trigger;

	public void OnTriggerEnter(Collider c){
		trigger.Enter (c, ref playerOnTrigger);
	}

	public void OnTriggerExit(Collider c){
		trigger.Exit(c, ref playerOnTrigger);
	}

	public bool isPlayerOnTrigger(){
		return playerOnTrigger;
	}

	public void setTriggerInterface(ITrigger t){
		trigger = t;
	}
}
