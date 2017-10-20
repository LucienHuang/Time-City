using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour {
	private Timer timerScript;

	// Use this for initialization
	void Start () {
		timerScript = GameObject.Find("Timer").GetComponent<Timer>();
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Button> ().onClick.AddListener (OnClick);
	}

	void OnClick(){
		timerScript.Restart ();
	}
}
