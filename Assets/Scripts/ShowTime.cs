using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTime : MonoBehaviour {
	
	private Timer timerScript;
	int totalTime;
	int minute;
	int second;
	int milisecond;
	float mescs;

	// Use this for initialization
	void Start () {
		timerScript = GameObject.Find("Timer").GetComponent<Timer>();
		minute = 0;
		second = 0;
		milisecond = 48;
		mescs = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		totalTime = timerScript.totalTime;
		if (totalTime >= 60) {
			minute = totalTime / 60;
		} else {
			minute = 0;
		}
		second = totalTime % 60;

		mescs += Time.deltaTime;

		if (mescs >= 1.0f) {
			mescs -= 1.0f;
			milisecond = 60;
		}

		milisecond -= 1;

		if (totalTime >= 0) {
			GetComponent<UnityEngine.UI.Text> ().text = minute + " : " + second + " : " + milisecond;
		} else {
			GetComponent<UnityEngine.UI.Text> ().text = "TIME UP";
		}
	}
}
