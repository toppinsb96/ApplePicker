using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
	public GameObject Apple_Prefab;
	public float speed = 1f;
	public float leftandRightEdge = 10f;
	public float chanceToChangeDirections = 0.1f;
	public float secondsBetweenAppleDrops = 1f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("DropApple", 2f, secondsBetweenAppleDrops);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;

		if (pos.x < -leftandRightEdge) {
			speed = Mathf.Abs(speed);
		} else if (pos.x > leftandRightEdge) {
			speed = -Mathf.Abs(speed);
		}
	}
	void FixedUpdate() {
		if(Random.value < chanceToChangeDirections) {
			speed *= -1;
		}
	}
	void DropApple() {
		GameObject apple = Instantiate (Apple_Prefab) as GameObject;
		apple.transform.position = transform.position;
	}
}
