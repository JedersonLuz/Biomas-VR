using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPopUp : MonoBehaviour {

	public Canvas popUp;

	public void ShowPopUp () {
		Debug.Log ("Pointer Down");
		popUp.gameObject.SetActive (true);
	}
}
