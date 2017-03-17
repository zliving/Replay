using UnityEngine;
using UnityEditor;
using NUnit.Framework;
using 
public class TriggerTest {

	[Test]
	public void TriggerContoller_OnTriggerEnter_Triggered() {
		//Arrange
		TriggerController tController = new TriggerController();


		//Assert
		//The object has a new name
		Assert.AreEqual(newGameObjectName, gameObject.name);
	}
}
