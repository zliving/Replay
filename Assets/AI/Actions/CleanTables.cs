using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class CleanTables : RAINAction
{
	Animator anim;
	GameObject barista;
    public override void Start(RAIN.Core.AI ai)
    {
		barista = GameObject.FindGameObjectWithTag ("AITag");
		anim = barista.GetComponent<Animator> ();
        base.Start(ai);
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