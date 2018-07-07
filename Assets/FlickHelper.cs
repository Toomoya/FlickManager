using UnityEngine;

public class FlickHelper
{
	float touchTime;
	Vector2 touchPos;

	const float minimumDistance = 30f;
	const float maxTime = 0.5f;
	const float minTime = 0.1f;

	public bool IsFlickRight {
		get {
			if (Input.GetMouseButtonUp (0)) {
				return IsFlick (Dir.RIGHT);
			} else {
				return false;
			}
		}
	}

	public bool IsFlickLeft {
		get {
			if (Input.GetMouseButtonUp (0)) {
				return IsFlick (Dir.LEFT);
			} else {
				return false;
			}
		}
	}

	public bool IsFlickUp {
		get {
			if (Input.GetMouseButtonUp (0)) {
				return IsFlick (Dir.UP);
			} else {
				return false;
			}
		}
	}

	public bool IsFlickDown {
		get {
			if (Input.GetMouseButtonUp (0)) {
				return IsFlick (Dir.DOWN);
			} else {
				return false;
			}
		}
	}

	public bool IsIsFlick {
		get {
			return false;
		}
	}

	public float FlickAngle {
		get{
			return 0;
		}
	}

	public void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			touchTime = Time.time;
			touchPos = Input.mousePosition;
		}
	}

	bool IsFlick (Dir dir)
	{
		float currentTimeTime = Time.time;
		Vector2 currentTouchPos = Input.mousePosition;
//		フリックをしているかどうかの判定
		bool isDistanceValid = Vector2.Distance (currentTouchPos, touchPos) > minimumDistance;
		bool isTimeValid = currentTimeTime - touchTime > minTime && currentTimeTime - touchTime < maxTime;
		if (!isDistanceValid || !isTimeValid)
			return false;

		float angle = GetAngle (touchPos, currentTouchPos);
//		角度によって分類していく
		switch (dir) {
		case Dir.RIGHT:
			return angle >= -45 && angle < 45;
		case Dir.LEFT:
			return (angle >= 135 && angle < 180) || (angle >= -180 && angle < -135);
		case Dir.UP:
			return angle >= 45 && angle < 135;
		case Dir.DOWN:
			return angle >= -135 && angle < -45;
		default:
			return false;
		}
	}
//	タッチ開始時とタッチ終了時の角度を取ってくる
	float GetAngle (Vector2 from, Vector2 to)
	{
		float radian = Mathf.Atan2 (to.y - from.y, to.x - from.x);
		return radian * Mathf.Rad2Deg;
	}

	enum Dir
	{
		RIGHT,
		LEFT,
		UP,
		DOWN
	}
}


//上下左右を拾ってくる