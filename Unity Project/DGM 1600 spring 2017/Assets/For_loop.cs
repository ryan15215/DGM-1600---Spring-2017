using UnityEngine;
using System.Collections;

public class For_loop : MonoBehaviour {
	public int bottles = 0;
	
	// Use this for initialization
	void Start () {
		for(int i=99;i>bottles;i--){
			print(i+"bottles of apple beer on the wall");
		}
	}


}