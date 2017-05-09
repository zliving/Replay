using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class OfCourse : RAINAction
{
	Dialogue audio;
    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
		audio = new Dialogue (ai, "Replay_Audio_5-2");
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		audio.play ();
		ai.WorkingMemory.SetItem<bool> ("customerOrdered", false);
        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}