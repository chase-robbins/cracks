using UnityEngine; 
using System.Collections;
public class scoreTrigger : MonoBehaviour { 
	public static int score = 0;
	//	public int totalScore;
	void OnTriggerEnter2D(Collider2D sweg){
		score++;
		//		totalScore++;
	}
}