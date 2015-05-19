using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameTimer : MonoBehaviour {

	public float gameStartTime;
	public Text uiTimer;
	public float speedUpCounter = 0;
	public cameraspeed cs;

	// Use this for initialization
	void Start () {
		gameStartTime = Time.time;

	}
	
	// Update is called once per frame
	void Update () {

		uiTimer.text = (Time.time - gameStartTime).ToString("0.##");
		speedUpCounter += Time.deltaTime;
		if (speedUpCounter > 5) {
			cs.cameraSpeedY += 0.5f;
			speedUpCounter -= 5;
		}

	}
}
