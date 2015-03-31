using UnityEngine;
using System.Collections;

public class cameraspeed : MonoBehaviour {

	public float cameraSpeedY = 1;
	public float cameraSpeedZ = 0;
	public float cameraSpeedX = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 camPos = transform.position;
		camPos.y -= Time.deltaTime * cameraSpeedY;
		transform.position = camPos;
//		transform.position = new Vector3 (cameraSpeedX + transform.position.x, cameraSpeedY + transform.position.y, transform.position.z);
//		Debug.Log (camPos);

	}
}
