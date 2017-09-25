using UnityEngine;
using System.Collections;

public class AppleController : MonoBehaviour {
	public static float     bottomY = -15f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if ( transform.position.y < bottomY ) {
			Destroy (this.gameObject);
			ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
			apScript.AppleDestroyed();
		}
	}
}
