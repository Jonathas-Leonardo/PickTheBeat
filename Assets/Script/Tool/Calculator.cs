using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator{

	public float CalcDistance(float vel, float time){
		return vel*time;
	}

	public float CalcTime(float distance, float vel){
		return distance / vel;
	}

	public float CalcVelocity(float distance, float time){
		return distance / time; 
	}
}
