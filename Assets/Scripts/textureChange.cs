using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class textureChange : MonoBehaviour {
	private int textureStage;
	private GameObject thisObject;
	//-- internal vars
	private float msecs=0;

	// Use this for initialization
	void Start () {
		textureStage = 0;
		thisObject = GameObject.Find ("FaceBig");
	}
	
	// Update is called once per frame
	void Update () {
		
		msecs += Time.deltaTime;
		if (msecs >= 1.0f) {
			msecs -= 1.0f;

			if (textureStage < 4) {
				textureStage++;
			} else {
				textureStage = 0;
			}

			if (textureStage == 0) {
				Texture img = (Texture)Resources.Load ("Clock_A_1");
				thisObject.GetComponent<Renderer> ().material.mainTexture = img;
			} else if(textureStage==1){
				Texture img = (Texture)Resources.Load ("Clock_A_2");
				thisObject.GetComponent<Renderer> ().material.mainTexture = img;
			} else if(textureStage==2){
				Texture img = (Texture)Resources.Load ("Clock_A_3");
				thisObject.GetComponent<Renderer> ().material.mainTexture = img;
			} else if(textureStage==3){
				Texture img = (Texture)Resources.Load ("Clock_A_4");
				thisObject.GetComponent<Renderer> ().material.mainTexture = img;
			} else if(textureStage==4){
				Texture img = (Texture)Resources.Load ("Clock_A_5");
				thisObject.GetComponent<Renderer> ().material.mainTexture = img;
			}
			Debug.Log (thisObject.GetComponent<Renderer> ().material.mainTexture);
		}

	}
}
