using UnityEngine;
using System.Collections;

public class switch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		public string light = "red";

		switch(light){
			case "red":
				print ("The light is red--STOP for crying out loud!!!");
			break;
			case "yellow":
				print ("The light is yellow--Slow Down!");
			break;
			case "green"
				print ("The light is green--Go Dog Go!");
			break;
			default:
				print ("That's not a valid color");
			break;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
