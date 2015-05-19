using UnityEngine;
using System.Collections;

public class turtle : MonoBehaviour {

	public cameraspeed crying;
	public gameTimer tears;
	public float startTime = 0;
	public float waitTimeTurtle = 0;
	public float speedChange = 2.0f;
	public bool needToBeChecked = false;


	void OnTriggerEnter2D () {
		needToBeChecked = true;
		startTime = Time.time;
		crying.cameraSpeedY  -= speedChange;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > startTime + 3000 && needToBeChecked){
			needToBeChecked = false;
			crying.cameraSpeedY  += speedChange;	
		}
		Debug.Log ("Camera Speed is " + crying.cameraSpeedY);	
	}
}
