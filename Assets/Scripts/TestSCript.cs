public class HealthManager
{
	public float healthAmount;

	public void TakeDamage(float damageAmount){
		healthAmount -= damageAmount;
	}
}