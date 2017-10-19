using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : MonoBehaviour {
	
	public AudioClip aBeingHit;

	private Timer timerScript;
	int totalTime;

	// Use this for initialization
	void Start () {
		timerScript = GameObject.Find("Timer").GetComponent<Timer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(){
		AudioSource.PlayClipAtPoint (aBeingHit, GameObject.Find ("RigidBodyFPSController").transform.position);
		timerScript.totalTime += 30;
		Destroy (gameObject);
	}
}
