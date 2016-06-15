// YouTube link: To follow

// Source: https://www.assetstore.unity3d.com/en/#!/content/2299
// Project file location: Radio Tower/Scripts

// The source code is the C# version of the JavaScript file by the same name in this repository

using UnityEngine;
using System.Collections;

public class RadioTower1 : MonoBehaviour {

	float BlinkSpeed = 1.0f;
	float LightOnIntensity = 1.0f;
	float LightOffIntensity = 0.0f;
	float SecondsPassed = 0.0f;

	// Use this for initialization
	void Start () {
		GetComponent<Light>().intensity = LightOnIntensity;
	}
	
	// Update is called once per frame
	void Update () {
		SecondsPassed += Time.deltaTime;
		if(GetComponent<Light>().intensity == LightOnIntensity && SecondsPassed >= BlinkSpeed)
		{
			GetComponent<Light>().intensity = LightOffIntensity;
			SecondsPassed = 0.0f;
		}

		else if(GetComponent<Light>().intensity == LightOffIntensity && SecondsPassed >= BlinkSpeed)
		{
			GetComponent<Light>().intensity = LightOnIntensity;
			SecondsPassed = 0.0f;
		}
	}
}
