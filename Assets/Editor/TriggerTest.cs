using UnityEngine;
using UnityEditor;
using NUnit.Framework;
using RAIN.Core;

public class TriggerTest {

	[Test]
	public void TriggerContoller_isPlayerOnTrigger_True() {
		// Create trigger object
		GameObject trigger = GameObject.CreatePrimitive(PrimitiveType.Cube);
		trigger.AddComponent<CounterTrigger> ();
		CounterTrigger counterTrigger = trigger.GetComponent<CounterTrigger> ();

		// Add ai with rig and tag for the "Enter" function inside of CounterTrigger.cs
		GameObject ai = GameObject.CreatePrimitive (PrimitiveType.Capsule);
		ai.AddComponent<AIRig> ();
		ai.tag = "AITag";

		// Create a player with collider
		GameObject go = GameObject.CreatePrimitive (PrimitiveType.Cube);
		go.AddComponent<BoxCollider> ();
		Collider c = go.GetComponent<BoxCollider> ();

		// Change tag for trigger to recognize
		go.tag = "PlayerTag";
	
		// Make sure that controller is not null
		counterTrigger.controller = new TriggerController();

		// Set the interface so that it is not null when trying to make method calls.
		counterTrigger.controller.setTriggerInterface (counterTrigger);

		// Call the event trigger
		counterTrigger.OnTriggerEnter (c);

		// Assert
		Assert.IsTrue (counterTrigger.controller.isPlayerOnTrigger ());
	}

	[Test]
	public void TriggerController_isPlayerOnTrigger_False() {
		// Create trigger object
		GameObject trigger = GameObject.CreatePrimitive(PrimitiveType.Cube);
		trigger.AddComponent<CounterTrigger> ();
		CounterTrigger counterTrigger = trigger.GetComponent<CounterTrigger> ();

		// Add ai with rig and tag for the "Enter" function inside of CounterTrigger.cs
		GameObject ai = GameObject.CreatePrimitive (PrimitiveType.Capsule);
		ai.AddComponent<AIRig> ();
		ai.tag = "AITag";

		// Create a object that does not have "PlayerTag" with collider
		GameObject go = GameObject.CreatePrimitive (PrimitiveType.Cube);
		go.AddComponent<BoxCollider> ();
		Collider c = go.GetComponent<BoxCollider> ();

		// Change tag for trigger to recognize
		go.tag = "NotThePlayerTag";

		// Make sure that controller is not null
		counterTrigger.controller = new TriggerController();

		// Set the interface so that it is not null when trying to make method calls.
		counterTrigger.controller.setTriggerInterface (counterTrigger);

		// Call the event trigger
		counterTrigger.OnTriggerEnter (c);

		// Assert
		Assert.IsFalse (counterTrigger.controller.isPlayerOnTrigger ());
	}
}
