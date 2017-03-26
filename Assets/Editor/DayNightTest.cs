using UnityEngine;
using UnityEditor;
using NUnit.Framework;
using AC.TimeOfDaySystemFree;

public class DayNightTest {

	[Test]
	public void isDay_True() {
		// Time of Day object
		var TODObject = new GameObject();
		TODObject.AddComponent<TimeOfDayManager> ();

		// Get time manager
		TimeOfDayManager time = TODObject.GetComponent<TimeOfDayManager> ();

		// Assign day settings
		time.dayInSeconds = 60.0f;

		// Set the time to 1 p.m.
		time.timeline = 13;

		// Update time to determine night or day.
		time.updateTime ();
	
		Assert.IsTrue (time.IsDay, "Not daytime");
	}

	[Test]
	public void isNight_True() {
		// Time of Day object
		var TODObject = new GameObject();
		TODObject.AddComponent<TimeOfDayManager> ();

		// Get time manager
		TimeOfDayManager time = TODObject.GetComponent<TimeOfDayManager> ();

		// Assign day settings
		time.dayInSeconds = 60.0f;

		// Set the time to 1 a.m.
		time.timeline = 1;

		// Update time to determine night or day.
		time.updateTime ();

		Assert.IsTrue (time.IsNight, "Not nighttime");
	}

	[Test]
	public void isDay_False() {
		// Time of Day object
		var TODObject = new GameObject();
		TODObject.AddComponent<TimeOfDayManager> ();

		// Get time manager
		TimeOfDayManager time = TODObject.GetComponent<TimeOfDayManager> ();

		// Assign day settings
		time.dayInSeconds = 60.0f;

		// Set the time to 1 a.m.
		time.timeline = 1;

		// Update time to determine night or day.
		time.updateTime ();

		Assert.IsFalse (time.IsDay, "Is daytime");
	}

	[Test]
	public void isNight_False() {
		// Time of Day object
		var TODObject = new GameObject();
		TODObject.AddComponent<TimeOfDayManager> ();

		// Get time manager
		TimeOfDayManager time = TODObject.GetComponent<TimeOfDayManager> ();

		// Assign day settings
		time.dayInSeconds = 60.0f;

		// Set the time to 3 p.m.
		time.timeline = 15;

		// Update time to determine night or day.
		time.updateTime ();

		Assert.IsFalse (time.IsNight, "Is nighttime");
	}
}
