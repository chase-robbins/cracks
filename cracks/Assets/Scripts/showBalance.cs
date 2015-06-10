using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showBalance : MonoBehaviour {
	
	public Text uiBalance;
	public cameraspeed cs2;
	public float knownBalance;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		if (knownBalance != cs2.balance) {
			uiBalance.text = (cs2.balance + "$");
			knownBalance = cs2.balance;
		}

	}
	}