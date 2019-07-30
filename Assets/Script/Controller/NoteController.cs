using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour {

	public Note note;

	// Use this for initialization
	void Start () {
		//note = new Note(0,0);
	}
	
	private void Update() {
		if(!note.isAlive){
			gameObject.SetActive(false);
		}	
	}
}