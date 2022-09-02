using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {
	public void play () {
		Application.LoadLevel (1);
		//Debug.Log ("play");
	}
	public void lvl() {
		Application.LoadLevel (1);
	}
	public void comic1 () {
		Application.LoadLevel (3);
	}
	public void comic2 () {
		Application.LoadLevel (4);
	}
	public void scene1 () {
		Application.LoadLevel (2);
		}
	public void scene2 () {
		Application.LoadLevel (5);
	}
	public void howtoplay () {
		Application.LoadLevel (7);
	}
	public void mainmenu () {
		Application.LoadLevel (0);
	}
	public void exit() {
		Application.Quit ();
	}	
}