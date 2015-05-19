using UnityEngine;
using System.Collections;

public class cameraspeed : MonoBehaviour {
	public float currentScore = 0;
	float tempPosY;
	public float cameraSpeedY = 1;
	public float cameraSpeedZ = 0;
	public float cameraSpeedX = 0;
	public int balance = 0;
	public UnityEngine.UI.Text scoreText;
	// Use this for initialization
	void Start () {
		tempPosY = transform.position.y;


		if(PlayerPrefs.HasKey("balance")){
			balance = PlayerPrefs.GetInt("balance");
			print ("balance set, it is "+balance);
		} else {
			print("balance not set");
		}

	}
	public float distance = 0;

	//when level ends or when camera is destroyed
	void OnDestroy () {
		PlayerPrefs.SetInt ("balance", balance);
		print ("saving balance as: " + balance);
	}


	[Tooltip("The last placed block in the game")]
	public GameObject previousBlock;

	public float margin = 1;
	
	// Update is called once per frame
	void Update ()
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
//		p.x = Random.RandomRange(-6.0f, 6.0f);
		newBlock.transform.position = p;
		previousBlock = newBlock;	
		scoreTrigger st = newBlock.GetComponent<scoreTrigger>();
		st.scoreText = scoreText;
	}
}
