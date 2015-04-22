using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {
	public float currentScore = 0;
	float tempPosY;
	void Start() {
		tempPosY = transform.position.y;
	}
	public float cameraSpeedY = 1;
	public float cameraSpeedZ = 0;
	public float cameraSpeedX = 0;

	public float distance = 0;

	[Tooltip("The last placed block in the game")]
	public GameObject previousBlock;

	public float margin = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
		//scorekeeper
	if(transform.position.y <= tempPosY - 5){
		currentScore = 0;
		Debug.Log(currentScore);
		currentScore = 0;
		Debug.Log(currentScore);
	}

	tempPosY = transform.position.y;
	{	
		Vector3 camPos = transform.position;
		float moveDelta = Time.deltaTime * cameraSpeedY;
		camPos.y -= moveDelta;
		distance = distance + moveDelta;
		transform.position = camPos;
//		transform.position = new Vector3 (cameraSpeedX + transform.position.x, cameraSpeedY + transform.position.y, transform.position.z);
//		Debug.Log (camPos);

		if (distance > margin - 1) {
		//create a new block
			CreateANewBlock();
			distance -= margin;
		}

	}
	void CreateANewBlock(){
		GameObject newBlock = Instantiate(previousBlock);
		Vector3 p = newBlock.transform.position;
		p.y -= margin;
		newBlock.transform.position = p;
		previousBlock = newBlock;
	}
}
