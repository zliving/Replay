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
	Animator anim;
	public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
		barista = GameObject.FindGameObjectWithTag ("AITag");
		script = barista.GetComponent<AIScript> ();
		anim = barista.GetComponent<Animator> ();
	}

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		anim.SetInteger ("state", 1);
		// Take the cup here.
		return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }


}