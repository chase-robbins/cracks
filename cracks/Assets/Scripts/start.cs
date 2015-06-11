using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

	//start script
//public IEnumerator WhateverILike(int WhateverYouLike){
		public void WhateverILIke(int swaginabag){
		scoreTrigger.score = 0;
//		float fadeTime = GameObject.Find ("").GetComponent<Fade> ().BeginFade (1);
//		yield return new WaitForSeconds (fadeTime);
		Application.LoadLevel ("scene2d");
		}
}

