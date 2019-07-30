using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

	public KeyCode key;
	public bool isPressed;
	public bool isEnabled;

	private void Update() {
		//KeyDown();
		//KeyUp();
	}

	void KeyPressed(){
		isPressed =	Input.GetKey(key);
	}

	void KeyDown(){
		if(Input.GetKeyDown(key)){
			isPressed=true;
		}
	}

	void KeyUp(){
		if(Input.GetKeyUp(key)){
			isPressed=false;
		}
	}
}