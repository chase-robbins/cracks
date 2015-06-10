using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class loadLastScore : MonoBehaviour {

	public Text score;

	// Use this for initialization
	void Start () {
	
		score.text = "Score: "+PlayerPrefs.GetInt("lastScore");
		
	}
	
	// Update is called once per frame
	void Update () {



	}
}
