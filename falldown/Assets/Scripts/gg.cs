using UnityEngine;
using System.Collections;

public class gg : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D glhf){
		if(glhf.gameObject.tag == "Player"){
			Application.LoadLevel ("mainmenu");
			Debug.Log("ggwp");

		}
	}

}
