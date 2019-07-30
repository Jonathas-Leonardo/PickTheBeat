using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackBehaviour: MonoBehaviour{

	public Spawner[] spawner;
	public GameObject prefab_obj;
	public Vector3[] pos;
	// Use this for initialization

	//private List<Note> listOfNotes = new List<Note>();
	public string songName;
	public float trackTime = 0;
	public int currentNote = 0;
	int framerate = 24;

	Calculator calculator = new Calculator();
	Recorder rec;
	//delegate methods = new{Start};

	List<Vector3> BuildTrack(Recorder rec){
		///rec = new Recorder(songName);
		List<Note>listOfNotes = rec.LoadRecord();
		List<Vector3> positionList = new List<Vector3>();
					// }
			foreach (Note note in listOfNotes)
			{
				float distNote = calculator.CalcDistance(framerate,note.time);
				int index = note.index;
				Vector3 vec = new Vector3(pos[index].x,0,distNote);
				positionList.Add(vec);
			}
			return positionList;
	}

	void Start () 
	{
		
	}
}