using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class PourCoffee : RAINAction
{
	GameObject barista;
	AIScript script;
	public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
		barista = GameObject.FindGameObjectWithTag ("AITag");
		script = barista.GetComponent<AIScript> ();
	}

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		script.setBoolean ("makeCoffee", true);
		return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }


}