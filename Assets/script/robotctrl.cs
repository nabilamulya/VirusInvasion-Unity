using UnityEngine;
using System.Collections;

public class robotctrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey (KeyCode.W)) {
		gameObject.transform.Translate (-0.5f,0,0);
	}
	if (Input.GetKey (KeyCode.D)) {
		gameObject.transform.Rotate (0,2,0);
	}
	if (Input.GetKey (KeyCode.A)) {
		gameObject.transform.Rotate(0,-2,0);
	}
	if (Input.GetKey (KeyCode.S)) {
		gameObject.transform.Translate (1,0,0);
}
}
}
