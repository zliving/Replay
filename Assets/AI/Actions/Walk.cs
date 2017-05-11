using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class Walk : RAINAction
{

	Animator anim;

    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
		anim = ai.Body.GetComponent<Animator> ();
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		anim.SetInteger ("state", 0);
        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}