using UnityEngine;
using System.Collections;

public class turtle : MonoBehaviour {

	public cameraspeed cameraScript;
//	public gameTimer timer;
	public float startTime = 0;
	public float waitTimeTurtle = 0;
	public float speedChange = 2.0f;
	public bool needToBeChecked = false;

	void Start(){
		findCamera();
	}
	void findCamera(){
		Camera mainCam = Camera.main;
		Debug.Log (mainCam);
		cameraScript = mainCam.GetComponent<cameraspeed> ();
	}


	void OnTriggerEnter2D () {
		findCamera();	
		needToBeChecked = true;
		startTime = Time.time;
		cameraScript.cameraSpeedY  -= speedChange;
		cameraScript.bottomParticles.Emit(100);
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > startTime + 3000 && needToBeChecked){
			needToBeChecked = false;
			cameraScript.cameraSpeedY  += speedChange;	
		}
//		Debug.Log ("Camera Speed is " + cameraScript.cameraSpeedY);	
	}
}
