using UnityEngine;
using System.Collections;

public class Operators : MonoBehaviour {
	public int One = 5;
	public int Two = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	// Addition -- Adds two values together
		Debug.Log(One + Two);
		Debug.Log(One + One);
		Debug.Log(Two+ Two);
	// Subtraction -- Subtracts a value from another
		Debug.Log(One - Two);
		Debug.Log(One - One);
		Debug.Log(Two - Two);
	//Multiplication -- Multiplies two values together
		Debug.Log(One * Two);
		Debug.Log(One * One);
		Debug.Log(Two * Two);
	//Division -- Divides one value by another
		Debug.Log(One / Two);
		Debug.Log(One / One);
		Debug.Log(Two / Two);
	// Modulus -- Remaining value after division 
		Debug.Log(One % Two);
	//Increment -- Increases a value by 1
		Debug.Log(++Two);
	//Decrement -- Decreases a value by 1
		Debug.Log(--Two);
	}
}
