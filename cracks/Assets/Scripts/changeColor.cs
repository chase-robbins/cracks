using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class changeColor : MonoBehaviour {

	public cameraspeed cs;

	// Use this for initialization
	void Start () {
		if(scoreTrigger.score >= 10 && scoreTrigger.score <=20){
			this.gameObject.GetComponent<SpriteRenderer>().color = new Color(22.0f/256, 160.0f/256, 133.0f/256, 1.0f);
			Debug.Log ("changed color");
		} 		
		if(scoreTrigger.score >= 21 && scoreTrigger.score <=30){
			this.gameObject.GetComponent<SpriteRenderer>().color = new Color(231.0f/256, 76.0f/256, 60.0f/256, 1.0f);
			Debug.Log ("changed color");
		} 
		if(scoreTrigger.score >= 31 && scoreTrigger.score <=40){
			this.gameObject.GetComponent<SpriteRenderer>().color = new Color(44.0f/256, 62.0f/256, 80.0f/256, 1.0f);
			Debug.Log ("changed color");
		} 
		if(scoreTrigger.score >= 41 && scoreTrigger.score <=50){
			this.gameObject.GetComponent<SpriteRenderer>().color = new Color(46.0f/256, 204.0f/256, 113.0f/256, 1.0f);
			Debug.Log ("changed color");
		} 
		if(scoreTrigger.score >= 51 && scoreTrigger.score <=60){
			this.gameObject.GetComponent<SpriteRenderer>().color = new Color(230.0f/256, 126.0f/256, 34.0f/256, 1.0f);
			Debug.Log ("changed color");
		} 
		if(scoreTrigger.score >= 61 && scoreTrigger.score <=70){
			this.gameObject.GetComponent<SpriteRenderer>().color = new Color(189.0f/256, 195.0f/256, 199.0f/256, 1.0f);
			Debug.Log ("changed color");
		} 
		if(scoreTrigger.score >= 71 && scoreTrigger.score <=80){
			this.gameObject.GetComponent<SpriteRenderer>().color = new Color(241.0f/256, 196.0f/256, 15.0f/256, 1.0f);
			Debug.Log ("changed color");
		} 
		if(scoreTrigger.score >= 91 && scoreTrigger.score <=100){
			this.gameObject.GetComponent<SpriteRenderer>().color = new Color(12.0f/256, 12.0f/256, 12.0f/256, 1.0f);
			Debug.Log ("changed color");
		} 
	}

	void Update(){


	}

}
