using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour {
	
	private GameObject timer;
	private Timer timerScript;

	// Use this for initialization
	void Start () {
//		GameObject.Find("text1").GetComponent<Text> = "hey";
		timerScript = GameObject.Find("Timer").GetComponent<Timer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(){
		timerScript.totalTime -= 20;
	}

	void OnTriggerExit(){
		
	}
}
