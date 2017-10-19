using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	public int totalTime;

	private float mescs;


	// Use this for initialization
	void Start () {
		totalTime = 180;
		mescs = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		mescs += Time.deltaTime;

		if (mescs >= 1.0f) {
			mescs-=1.0f;
			totalTime -= 1;;
		}

		Debug.Log (totalTime);
	}
}
