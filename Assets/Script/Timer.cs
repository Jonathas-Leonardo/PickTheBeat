using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

public float currentTime;
public float stepTime;
public bool isEnd;
	
	// Update is called once per frame
	void Update () {
		if(Time.time>currentTime){
			AddCurrentTime();
			isEnd=true;
		}
	}

	public void StartTimer(){
		AddCurrentTime();
		isEnd=false;
	}

	public void UpdateTime(){
		currentTime = Time.time+stepTime;
	}

	public void AddCurrentTime(){
		currentTime += stepTime;
	}
}