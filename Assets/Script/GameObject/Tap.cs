using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour {
	
	public bool isTap;
	public bool isTouch;
	ShinyEffect effect;

	// Use this for initialization
	void Start () {
		effect = GetComponent<ShinyEffect>();
	}
	
	// Update is called once per frame
	void Update () {
		effect.isEffect02 = isTouch;
	}

	private void OnTriggerEnter(Collider other) 
	{
		if(other.tag == "note"){
			isTouch = true;
		}
	}

	private void OnTriggerStay(Collider other) 
	{
		if(other.tag == "note" && isTap){
			other.GetComponent<Note>().isAlive = false;
			isTap = false;
			isTouch = false;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if(other.tag == "note"){
			isTouch = false;
		}
	}
}
