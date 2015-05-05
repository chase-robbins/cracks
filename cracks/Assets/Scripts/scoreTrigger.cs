using UnityEngine; 
using UnityEngine.UI;
using System.Collections;
public class scoreTrigger : MonoBehaviour { 
	public Text scoreText;
	public static int score = 0;
	//	public int totalScore;
	void OnTriggerEnter2D(Collider2D sweg){
		score++;
		Debug.Log ("SWAG");
		//		totalScore++;
		scoreText.text = "Score: " + score;
	}
	void Update () {

		
	}
}