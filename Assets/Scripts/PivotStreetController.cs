using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotStreetController : MonoBehaviour {

	public StreetController myControl;
	public int index;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerExit2D(Collider2D collisonInfo) {
		Debug.Log ("Eu quero isso... " + this.index);
		myControl.setIndex (this.index);
	}

	// Update is called once per frame
	void Update () {
	}
}
