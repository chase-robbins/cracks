using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showBalance : MonoBehaviour {
	
	public Text uiBalance;
	public cameraspeed cs2;

	// Use this for initialization
	void Start () {
		uiBalance.text = (cs2.balance + "$");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	}