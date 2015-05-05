using UnityEngine;
using System.Collections;

public class startLocations : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		transform.position = new Vector2 (Random.RandomRange(-5.0f, 5.0f), transform.position.y);
	}

}
	