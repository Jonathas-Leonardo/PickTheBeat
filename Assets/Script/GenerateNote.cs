using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GenerateNote : MonoBehaviour {

	public Spawner[] spawner;
	public Tap[] tapper;
	Keyboard inputs;
	// Use this for initialization

	private List<Note> listOfNotes = new List<Note>();

	public enum GAMESTATE { PLAY, RECORD };
	public GAMESTATE gameState;
	public string songName;
	public float trackTime = 0;
	public int currentNote = 0;
	int framerate = 24;

	//Recorder rec;
	Calculator calculator = new Calculator();

	//delegate methods = new{Start};
	
	void Start () 
	{
		//rec = new Recorder(songName);
		//inputs = GetComponent<Keyboard>();

		// if(gameState == GAMESTATE.PLAY){
		// 	listOfNotes = rec.LoadRecord();
		// 	foreach (Note note in listOfNotes)
		// 	{
		// 		float distNote = calculator.CalcDistance(framerate,note.time);
		// 		int index = note.index;
		// 		Vector3 vec = new Vector3(spawner[index].transform.position.x,0,distNote);
		// 		GameObject gobj = Instantiate(spawner[index].prefab_obj,vec,Quaternion.identity);
		// 		gobj.transform.parent = transform;
		// 	}			
		// }
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		trackTime += Time.fixedDeltaTime;
		//8/Time.fixedDeltaTime

		if(gameState == GAMESTATE.RECORD){
			RecorderInput();
		}
		else if(gameState == GAMESTATE.PLAY){
			if(currentNote<listOfNotes.Count){
				if(listOfNotes[currentNote].time<Time.time){
					//DrawNote(listOfNotes[currentNote].indexOfTrack);
					//currentNote++;
				}
			}
		}
	}

	public void BuildRoadNote(List<Note> listOfNotes){
		foreach (Note note in listOfNotes)
		{
			float distNote = calculator.CalcDistance(framerate,note.time);
			int index = note.index;
			Vector3 vec = new Vector3(spawner[index].transform.position.x,0,distNote);
			GameObject gobj = Instantiate(spawner[index].prefab_obj,vec,Quaternion.identity);
			gobj.transform.parent = transform;
		}	
	}

	void RecorderInput(){
		if(Input.GetKeyDown(inputs.TapOne)){
			DrawNote(0);
			AddNote(0, trackTime);
		}
		if(Input.GetKeyDown(inputs.TapTwo)){
			DrawNote(1);
			AddNote(1, trackTime);
		}
		if(Input.GetKeyDown(inputs.TapThree)){
			DrawNote(2);
			AddNote(2, trackTime);
		}
		if(Input.GetKeyDown(inputs.TapFour)){
			DrawNote(3);
			AddNote(3, trackTime);
		}
		if(Input.GetKeyDown(inputs.TapFive)){
			DrawNote(4);
			AddNote(4, trackTime);
		}
		if(Input.GetKeyDown(inputs.TapSpecial)){
			//rec.DeleteRecord();
			//rec.SaveRecord(listOfNotes);
		}
	}

	void GameInput(){
		//input for play
	}



	void DrawNote(int index){
		spawner[index].Spawn();
		//tapper[index].isTap=true;
	}

	void AddNote(int index, float time){
		listOfNotes.Add(new Note(index,time));
	}
}