using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class OrderCoffee : RAINAction, IDialogue
{
	AudioSource source;
	AudioClip clip;
    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
		source = ai.Body.GetComponent<AudioSource> ();
		clip = (AudioClip)Resources.Load ("Replay_Audio_1-2");
		source.clip = clip;
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		// Add Audio for ordering a coffee.
		dialogue();
        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }

	public void dialogue(){
		source.Play ();
	}
}