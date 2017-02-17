using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public int moveSpeed = 10;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*Transform tran = transform;
        transform.position = new Vector3(0,0,moveSpeed);*/

		transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
	}
}
