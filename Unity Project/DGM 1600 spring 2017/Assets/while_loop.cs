using UnityEngine;
using System.Collections;

public class while_loop : MonoBehaviour {
	public int ammo = 1;

	// Use this for initialization
	void Start () {
		while(ammo < 12){
			ammo++;
			print ("Loading round" + ammo);
			
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
