using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

	int h, w;

	void Start () {
		h = Screen.height / 2;
		w = Screen.width / 2;
	}

	void Update () {
		if (Input.touchCount > 0 || Input.GetButton("Fire1")) {
			Ray ray = Camera.main.ScreenPointToRay (new Vector3 (h, w, 0));

			Debug.DrawRay (ray.origin, ray.direction * 1000, Color.red);
		}
	}
}
