using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class Apologize : RAINAction, IDialogue
{
	AIRig customerRig;
    public override void Start(RAIN.Core.AI ai)
    {
		customerRig = GameObject.FindGameObjectWithTag ("CustomerTag").GetComponent<AIRig> ();
        base.Start(ai);
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		dialogue ();
		customerRig.AI.WorkingMemory.SetItem<bool> ("cupTrigger", true);
        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }

	public void dialogue(){
	
	}
}