using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Note{
	public int index;
	public float time;
	public int point;
	public bool isAlive;

	public Note(int index, float time)
	{
		isAlive = true;
		this.point = 10;
		this.index = index;
		this.time = time;
	}
}