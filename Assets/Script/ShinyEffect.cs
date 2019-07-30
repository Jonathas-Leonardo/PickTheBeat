using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShinyEffect : MonoBehaviour {

	Color32 startColor;
	public Color32 transationColor;
	Renderer rend;
	float lerpTime;
	const float time = 0.1f;
	public bool isEffect;
	public bool isEffect02;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;
	}

	void Update() {
		if(isEffect){
			DoEffect();
		}else if(isEffect02){
			DoEffect02();
		}
		else{
			ResetEffect();
		}
	}
	
	public void DoEffect02(){
		rend.material.color = Color32.Lerp(startColor,transationColor,lerpTime);
		lerpTime+= time;
	}

	// Update is called once per frame
	public void DoEffect () {
		rend.material.color = Color32.Lerp(startColor,transationColor,Mathf.PingPong(lerpTime,1));
		lerpTime+= time;
	}

	public void ResetEffect(){
		rend.material.color = startColor;
		lerpTime=0;
	}
}