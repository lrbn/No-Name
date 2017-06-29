using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletProperties : MonoBehaviour {

	public float pelletLifeTime = 2.0f;

	// Update is called once per frame
	void Update () {
		Destroy (this.gameObject, pelletLifeTime);
	}
}
