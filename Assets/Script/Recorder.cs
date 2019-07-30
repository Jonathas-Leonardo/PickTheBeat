using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Recorder{

	private const string PATH = @"Assets\Files\{0}.txt";
	private string path;

	Calculator calculator = new Calculator();

	public Recorder(string songname)
	{
		this.path = string.Format(PATH,songname);
	}

	public void SaveRecord(List<Note> listOfNotes){
		if(listOfNotes.Count==0){
			Debug.Log("musica sem nota");
			return;
		}

		using (StreamWriter file = new StreamWriter(path, true))
        {
			for (int i = 0; i < listOfNotes.Count; i++)
			{
				if(i==0){
					file.WriteLine(listOfNotes[i].index+"#"+listOfNotes[i].time);
				}else{
					file.WriteLine("#"+listOfNotes[i].index+"#"+listOfNotes[i].time);
				}
			}
			Debug.Log("save - "+path);
        }
	}

	public List<Note> LoadRecord(){		
		using (StreamReader file = new StreamReader(path,true))
        {
			string text = file.ReadToEnd();
			text = text.Replace("\r","").Replace("\n","");
			string[] values = text.Split('#');
			return BuildListOfNotes(values);
		}
	}

	public void DeleteRecord(){
		FileInfo fileInfo = new FileInfo(path);
		if(fileInfo != null){
			fileInfo.Delete();
		}
	}

	private List<Note> BuildListOfNotes(string[] values){
		List<Note> listOfNotes = new List<Note>();
		for (int i = 0; i < values.Length; i+=2)
		{
			int index = int.Parse(values[i]);
			float time = float.Parse(values[i+1]);
			Note note = new Note(index,time);
			listOfNotes.Add(note);
		}
		return listOfNotes;
	}

	bool ListOfNoteIsNull(List<Note> listOfNotes){
		return (listOfNotes.Count==0);
	}

	// public List<Vector3> BuildTrack(Vector3[] pos, int framerate){
	// 	List<Note>listOfNotes = LoadRecord();
	// 	List<Vector3> positionList = new List<Vector3>();

	// 	foreach (Note note in listOfNotes)
	// 	{
	// 		float distNote = calculator.CalcDistance(framerate, note.time);
	// 		int index = note.indexOfTrack;
	// 		Vector3 vec = new Vector3(pos[index].x,0,distNote);
	// 		positionList.Add(vec);
	// 	}
	// 	return positionList;
	// }
}