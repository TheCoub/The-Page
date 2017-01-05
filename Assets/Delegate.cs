using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Delegate : MonoBehaviour {

	public GameObject note;
	public string country = "DPRK";

	// Use this for initialization
	void Start () {
		MakeNote ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void MakeNote (){
		Instantiate (note, this.transform.position + new Vector3(0, 1, 0), Quaternion.identity, this.transform);
	}

	public bool DeliverNote(List<Note> notes){
		foreach(Note inNote in notes){
			if (inNote.intendedCountry == country) {
				RecieveNote ();
				print ("Foreach run");
				return true;
			}
		} 
		return false;
	}

	void RecieveNote(){
		
	}
}
