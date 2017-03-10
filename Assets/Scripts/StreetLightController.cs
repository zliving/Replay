using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC.TimeOfDaySystemFree;

public class StreetLightController : MonoBehaviour {


	private TimeOfDayManager newDayCycleManager = null;
	public GameObject[] streetLights;
	public GameObject[] streetLightFlares;
	private Light lampLight;
	private LensFlare lampFlare;


	// Use this for initialization
	void Start () {

		newDayCycleManager = GetComponent<TimeOfDayManager> ();
		streetLights = GameObject.FindGameObjectsWithTag("Lamp Light");
		streetLightFlares = GameObject.FindGameObjectsWithTag("Lamp Flare");
		
	}
	
	// Update is called once per frame
	void Update () {

		if (newDayCycleManager.IsNight) {
			
			foreach (GameObject streetLight in streetLights) {
				lampLight = streetLight.GetComponent<Light> ();
				lampLight.enabled = true;
			}
			foreach (GameObject streetLightFlare in streetLightFlares) {
				lampFlare = streetLightFlare.GetComponent<LensFlare> ();
				lampFlare.enabled = true;
			}

		} else if (newDayCycleManager.IsDay) {

			foreach (GameObject streetLight in streetLights) {
				lampLight = streetLight.GetComponent<Light> ();
				lampLight.enabled = false;
			}
			foreach (GameObject streetLightFlare in streetLightFlares) {
				lampFlare = streetLightFlare.GetComponent<LensFlare> ();
				lampFlare.enabled = false;
			}

		}

	}
}
