using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class Stand : RAINAction
{
	Animator anim;

    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
		anim = ai.Body.GetComponent<Animator> ();
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		anim.SetInteger ("state", 1);
        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}