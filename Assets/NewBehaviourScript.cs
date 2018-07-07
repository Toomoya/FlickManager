using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	FlickHelper flickHelper;
	// Use this for initialization
	void Start () {
		flickHelper = new FlickHelper ();
	}
	
	// Update is called once per frame
	void Update () {
		flickHelper.Update ();
//		上下左右どっちにフリックいているのかを判定
		if (flickHelper.IsFlickRight) {
			Debug.Log ("flicked right");
		}
		if (flickHelper.IsFlickLeft) {
			Debug.Log ("flicked left");
		}
		if (flickHelper.IsFlickUp) {
			Debug.Log ("flicked up");
		}
		if (flickHelper.IsFlickDown) {
			Debug.Log ("flicked down");
		}

		if (flickHelper.IsIsFlick) {
			Debug.Log (flickHelper.FlickAngle);
		}

	}
}
