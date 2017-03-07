using UnityEngine;

public interface ITrigger{
	void Enter(Collider c, ref bool onTrigger);
	void Exit(Collider c, ref bool onTrigger);
}

