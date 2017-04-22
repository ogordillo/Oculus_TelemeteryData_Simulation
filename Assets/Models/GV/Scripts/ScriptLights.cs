using System.Collections.Generic;
using UnityEngine;
using System.Collections;




public class ScriptLights : MonoBehaviour {

	public bool blink;
	[Header("Lights")]
	public bool frontLightsOn;
	public bool backLightsOn;
	public GameObject frontLighs;
	public GameObject backLights;

	private IEnumerator coroutine;


	void Start () {
		blink 			= false;
		frontLightsOn 	= false;
		backLightsOn 	= false;

		coroutine = WaitAndPrint(1.0f);
		StartCoroutine(coroutine);
	
	}
	

	void Update () {
		if (blink) {
			TurnOnFrontLights ();
			TurnOnBackLights ();
		}
		
	}

	public void TurnOnFrontLights()
	{
		if (frontLightsOn) {
			frontLighs.SetActive (true);
		} else {
			frontLighs.SetActive (false);
		}
	}

	public void TurnOnBackLights()
	{
		if (backLightsOn) {
			backLights.SetActive (true);
		} else {
			backLights.SetActive (false);
		}
	}



	private IEnumerator WaitAndPrint(float waitTime) {
		while (true) {
			yield return new WaitForSeconds(waitTime);
			frontLightsOn = !frontLightsOn;
			backLightsOn = !backLightsOn;
		}
	}



}
