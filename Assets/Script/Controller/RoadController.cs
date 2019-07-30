using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour {

	public Road road;
	int framerate = 24;
	public Spawner[] spawner;
	public GameObject note_prefab;
	public GameObject notes;

	Recorder rec;
	Calculator calculator = new Calculator();

	// Use this for initialization
	void Start () {
		if(GameManager.gameState == GAMESTATE.PLAY){
			rec = new Recorder(GameManager.songName);
			road.listOfNotes = rec.LoadRecord();
			road.numberOfNotes = road.listOfNotes.Count;
			BuildRoadNote(road.listOfNotes);
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3(0,0,road.speed);
	}

	public void BuildRoadNote(List<Note> listOfNotes){
		foreach (Note note in listOfNotes)
		{
			float distNote = calculator.CalcDistance(framerate,note.time);
			int index = note.index;
			Vector3 vec = new Vector3(spawner[index].transform.position.x,0,distNote);
			note_prefab.GetComponent<NoteController>().note = note;
			GameObject gobj = Instantiate(note_prefab,vec,Quaternion.identity);
			gobj.transform.parent = transform;
		}	
	}
}
