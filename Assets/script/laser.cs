using UnityEngine;
using System.Collections;

public class laser : MonoBehaviour {

	
	void OnCollisionEnter(Collision c)
	{
		// c.gameObject is the GameObject you're colliding with
		if (c.gameObject.name == "laser")
		{
			score.hasil++;
			Destroy(c.gameObject);
		}
		// This should be the GameObject that has this script attached
	}
}
