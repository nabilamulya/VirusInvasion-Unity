using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class score : MonoBehaviour {

	public Text Nilai;
	public static int hasil;

	void Start () {
	hasil=0;
	}
	
	void Update () {
		Nilai.text = "Score :" + hasil;
		if (hasil == 15) {
		Application.LoadLevel(8);
		}
	}
}
