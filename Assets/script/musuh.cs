using UnityEngine;
using System.Collections;

public class musuh : MonoBehaviour {
	
	void OnCollisionEnter(Collision c)
	{
		// c.gameObject is the GameObject you're colliding with
		if (c.gameObject.name == "roBot")
		{
			Application.LoadLevel (10);
		}
		// This should be the GameObject that has this script attached
	}
}
