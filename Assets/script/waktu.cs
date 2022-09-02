using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class waktu : MonoBehaviour
{
	public Text Waktu;
	public float timeLeft = 120.0f;
	
	public void Update()
	{
		timeLeft -= Time.deltaTime;
		
		if (timeLeft <= 0.0f)
		{
			// End the level here.
			Application.LoadLevel(5);
		}
		else
		{
			Waktu.text = "Time : " + (int)timeLeft + "s";
		}
		
	}
	
}