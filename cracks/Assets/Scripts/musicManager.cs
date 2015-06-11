using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class musicManager : MonoBehaviour {

//	public bool isPlaying;
	public int isPlaying;
	public GameObject src;

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
	// Use this for initialization
	void Start () {
		Debug.Log ("boolean check 1 = " + isPlaying);
		if (isPlaying == 0) {
//insert logic on starting music bellow
			src.SetActive (true);
			isPlaying = 1;
			Debug.Log("Music playing, boolean check 2 for background music = " + isPlaying);

		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
