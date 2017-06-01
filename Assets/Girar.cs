using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girar : MonoBehaviour {

	Quaternion pos;
	// Use this for initialization
	void Start () {
		pos = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		pos.y += 50f;
		transform.rotation = pos;
	}
}
