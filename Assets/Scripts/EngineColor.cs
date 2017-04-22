using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EngineColor : MonoBehaviour {

	public GameObject engine00; 

	public float Speed = 0.0f;
	float first_speed = 0.0f;

	float second_speed = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Speed < 0.5f) {
			first_speed = Speed * 2;
			engine00.GetComponent<Renderer> ().material.SetColor ("_Color", Color.Lerp (Color.green, Color.yellow, first_speed));
			//engine01.GetComponent<Renderer> ().material.SetColor ("_Color", Color.Lerp (Color.green, Color.yellow, first_speed));

		} else if (Speed > 0.5f) {
			second_speed = (Speed - 0.5f) * 2;
			//engine00.GetComponent<Renderer>().material.SetColor("_Color", HSBColor.ToColor(Mathf.PingPong(Time.time * Speed, 1),1,1));

			engine00.GetComponent<Renderer> ().material.SetColor ("_Color", Color.Lerp (Color.yellow, Color.red, second_speed));
			//engine01.GetComponent<Renderer> ().material.SetColor ("_Color", Color.Lerp (Color.yellow, Color.red, second_speed));

		}
	}


	public void setColorValue(float val)
	{
		this.Speed = val;
		//engine00.GetComponent<Renderer>().material.SetColor("_Color", HSBColor.ToColor(Mathf.PingPong(Time.time * Speed, 1),1,1)));
	}
}
