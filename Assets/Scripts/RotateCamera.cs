﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour {



	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward, 10.0f * Time.deltaTime);
	}
}
