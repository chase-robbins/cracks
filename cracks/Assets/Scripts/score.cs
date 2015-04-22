using UnityEngine; 
using System.Collections;

public class score : MonoBehaviour { 
	
	public float currentScore = 0;
	float tempPosY;
	void Start() {
		tempPosY = transform.position.y;
	}
	
	void Update () {
		if(transform.position.y <= tempPosY - 5){
			currentScore = 0;
			Debug.Log(currentScore);
				currentScore = 0;
			Debug.Log(currentScore);
		}
		tempPosY = transform.position.y;
	}
}