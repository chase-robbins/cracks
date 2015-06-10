using UnityEngine;
using System.Collections;
public class gg : MonoBehaviour {
	
	public cameraspeed cspeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D glhf){
		if(glhf.gameObject.tag == "Player"){
			Application.LoadLevel ("gameover");
			cspeed.balance += scoreTrigger.score;
			Debug.Log("ggwp");
//			scoreTrigger.score = 0;
//			PlayerPrefs.SetInt("balance", cspeed.balance + scoreTrigger.score);

		}
	}

}
