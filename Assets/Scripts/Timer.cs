using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	public int totalTime;
	public int gotProp;

	private float mescs;
	private GameObject chara;
	private Vector3 startPos;

	// Use this for initialization
	void Start () {
		chara = GameObject.Find ("RigidBodyFPSController");
		startPos = chara.gameObject.transform.position;
		totalTime = 180;
		mescs = 0.0f;
		gotProp = 0;
	}
	
	// Update is called once per frame
	void Update () {
		mescs += Time.deltaTime;

		if (mescs >= 1.0f) {
			mescs-=1.0f;
			totalTime -= 1;;
		}
		if (totalTime <= 0) {
			Restart ();
		}
	}

	public void Restart(){
		Debug.Log ("OH!");
		chara.gameObject.transform.position = startPos;
		totalTime = 180+gotProp*30;
	}
}
