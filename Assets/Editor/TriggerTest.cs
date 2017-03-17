using UnityEngine;
using UnityEditor;
using NUnit.Framework;
using 
public class TriggerTest {

	[Test]
	public void TriggerContoller_OnTriggerEnter_Triggered() {
		//Arrange
		TriggerController tController = new TriggerController();
		GameObject go = GameObject.CreatePrimitive (PrimitiveType.Cube);
		BoxCollider bCollider = new BoxCollider ();
		go.AddComponent<Collider> (bCollider);
		go.tag = "PlayerTag";
		tController.OnTriggerEnter (go.GetComponent<Collider> ());
		Assert.IsTrue(

	}
}
