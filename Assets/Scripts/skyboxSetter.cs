using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxSetter : MonoBehaviour {

	private float msecs = 0.0f;
	private Texture upImg;
	private bool isOn;

	// Use this for initialization
	void Start () {
		upImg = (Texture)Resources.Load ("top");
		isOn = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		msecs += Time.deltaTime*2;
		if (msecs >= 1.0f) {
			msecs -= 1.0f;
			isOn = !isOn;

			if (isOn) {
				upImg = (Texture)Resources.Load ("top");
				Camera.main.GetComponent<Skybox> ().material.SetTexture ("_UpTex", upImg);
			} else {
				upImg = (Texture)Resources.Load ("top-2");
				Camera.main.GetComponent<Skybox> ().material.SetTexture ("_UpTex", upImg);
			}
		}
	}
}
