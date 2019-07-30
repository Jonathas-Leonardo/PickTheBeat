using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentor : MonoBehaviour {

	public void WalkForward(float speed){
		transform.position += transform.forward*speed;
	}
}
