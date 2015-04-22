using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {
	public AudioClip tooMLG;
	private AudioSource tooMLG4U;
	// Use this for initialization
	void Start () {
//		tooMLG4U = GetComponent <AudioSource>();
//		tooMLG4U.PlayOneShot(tooMLG, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//start script
	public void WhateverILike(){
		Application.LoadLevel ("scene2d");

	}
}
