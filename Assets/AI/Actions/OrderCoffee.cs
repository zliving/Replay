using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class OrderCoffee : RAINAction
{
	AIRig barista;
    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
		barista = GameObject.FindGameObjectWithTag ("AITag").GetComponentInChildren<AIRig> ();
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		// Add Audio for ordering a coffee.
		barista.AI.WorkingMemory.SetItem<bool> ("customerOrdered", true);
        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}