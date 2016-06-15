// YouTube link: To follow

// Source: https://www.assetstore.unity3d.com/en/#!/content/2299
// Project file location: Radio Tower/Scripts

// The source code on the Unity Asset store as at 26th Feb 2015 is not compatible with Unity 5.x.x
// This file corrects the code and allows the animation to work

var BlinkSpeed : float = 1.0;
var LightOnIntensity : float = 1.0;
var LightOffIntensity : float = 0.0;
private var SecondsPassed : float = 0.0;

function Start(){GetComponent.<Light>().intensity = LightOnIntensity;}
function Update() 
{
	SecondsPassed += Time.deltaTime;
	if(GetComponent.<Light>().intensity == LightOnIntensity && SecondsPassed >= BlinkSpeed)
	{
		GetComponent.<Light>().intensity = LightOffIntensity;
		SecondsPassed = 0.0;
	}
	
	else if(GetComponent.<Light>().intensity == LightOffIntensity && SecondsPassed >= BlinkSpeed)
	{
		GetComponent.<Light>().intensity = LightOnIntensity;
		SecondsPassed = 0.0;
	}
}
