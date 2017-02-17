using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string light = "green";

		switch (light){
			case "red":
				print("The light is red--STOP for crying out loud!!!");
			break;
			case "yellow":
				print("thelight is yellow--Slow Down!!");
			break;
			case "green":
				print("the light is green--Go Dog Go!");
			break;
			default:
				print("that's not a valid color.");
			break;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}