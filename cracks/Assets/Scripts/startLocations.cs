﻿using UnityEngine;
using System.Collections;


public class startLocations : MonoBehaviour {
	public GameObject[] array;
	public GameObject turtlePrefab;


	// Use this for initialization
	void Start () {
		turtlePrefab.SetActive(false);
		transform.position = new Vector2 (Random.Range(-5.0f, 5.0f), transform.position.y);
		int percentage = (Random.Range(0, 100));
//		Debug.Log(percentage);
		if (percentage >= 96) {
			turtlePrefab.SetActive(true);
		}
	}

}
	