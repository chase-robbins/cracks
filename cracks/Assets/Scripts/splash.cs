using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class splash : MonoBehaviour {

	public float gameStartTime;
	public Text uiTimer;
	public float speedUpCounter = 0;
//	public cameraspeed cs;
	
	// Use this for initialization
	void Start () {
		gameStartTime = Time.time;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time>3) {
			Debug.Log("passed 3 sec");
		Application.LoadLevel("mainmenu");
		}

			Debug.Log ("" + Time.time);
		
	}
}
