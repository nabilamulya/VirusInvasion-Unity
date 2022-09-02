using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class score2 : MonoBehaviour {

	public Text Nilai;
	public static int hasil;

	void Start () {
	hasil=0;
	}
	
	void Update () {
		Nilai.text = "Score :" + hasil;
		if (hasil == 20) {
		Application.LoadLevel(9);
		}
	}
}
