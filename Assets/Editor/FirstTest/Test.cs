using NUnit.Framework;

[TestFixture]
public class HealthManagerTest {
	[Test]
	public void Take_Damage_PositiveAmount_Healthupdated(){
		var health = new HealthManager ();
		health.healthAmount = 50f;
		health.TakeDamage (10f);
		Assert.AreEqual (40f, health.healthAmount);
	}
}
