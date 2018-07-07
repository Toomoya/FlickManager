using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FlickManager : MonoBehaviour {

	public float flickTime = 0.15f;     //フリック判定用 時間しきい値
	public float flickMagnitude = 100;  //フリック判定用 移動距離

	private Vector3 startPosition;               //タップ開始ポイント
	private Vector3 endPosition;                 //タップ終了ポイント

	private float timer = 0.0f;         //フリック判定用 タイマー

	FlickHelper flickHelper;

	void Start(){
		flickHelper = new FlickHelper ();
	}
	void Update() {
		flickHelper.Update ();
		if (flickHelper.IsFlickRight) {
			Debug.Log ("flick right");
		}
		if (flickHelper.IsFlickLeft) {
			Debug.Log ("flick left");
		}
		if (flickHelper.IsFlickUp) {
			Debug.Log ("flick up");
		}
		if (flickHelper.IsFlickDown) {
			Debug.Log ("flick down");
		}
		
//		//タップ開始時
//		if (Input.GetTouch(0).phase == TouchPhase.Began) {
//			//タップ開始ポイントを取得
//			startPosition = Input.GetTouch(0).position;
//		}
//		//タップ終了時
//		if (Input.GetTouch(0).phase == TouchPhase.Ended) {
//			//タップ終了ポイントを取得
//			endPosition = Input.GetTouch(0).position;
//
//			//タップ開始～終了ポイントの距離
//			Vector3 direction = endPosition - startPosition;
//
//			//距離が指定以上、タップ時間が指定以下の場合、フリックと判定
//			if (direction.magnitude >= flickMagnitude && timer <= flickTime) {
//				Debug.Log ("hoge");
//				//x軸の距離が大きい場合は左右へのフリック
////				if (Mathf.Abs(direction.x) >= Mathf.Abs(direction.y)) {
////					if (direction.x >= 0) {
////						//Right Flick
////						Debug.Log("右");
////					}
////					else {
////						//Left Flick
////						Debug.Log("左");
////					}
////				}
////				//y軸の距離が大きい場合は上下のフリック
////				else if (Mathf.Abs(direction.x) < Mathf.Abs(direction.y)) {
////					if (direction.y >= 0) {
////						//Up Flick
////						Debug.Log("上");
////					}
////					else {
////						//Down Flick
////						Debug.Log("下");
////		
	}
}