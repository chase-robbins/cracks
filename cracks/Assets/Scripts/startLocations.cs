using UnityEngine;
using System.Collections;


public class startLocations : MonoBehaviour {
	public GameObject[] array;

	// Use this for initialization
	void Start () {
		transform.position = new Vector2 (Random.RandomRange(-5.0f, 5.0f), transform.position.y);
		int percentage = (Random.RandomRange(0, 100));
		Debug.Log(percentage);
		if (percentage >= 95) {
		
		}
	}

}
	