using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	float n =0;
	float bounse = 10;
	void Update () {

		n += Time.deltaTime;
		bounse -= Time.deltaTime;

		if (bounse > 0.01f) {
			this.transform.position = new Vector3 (n, Mathf.Abs (bounse * Mathf.Sin (Time.time)), 0);
		}
	}
}
