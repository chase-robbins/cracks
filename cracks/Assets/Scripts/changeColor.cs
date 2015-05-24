using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class changeColor : MonoBehaviour {

	public scoreTrigger st;
	public GameObject line;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (scoreTrigger.score > 50 && scoreTrigger.score < 100){

			line..material.color = Color.red;


		}
	}
}
