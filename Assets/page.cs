using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Page : MonoBehaviour {

	public Rigidbody2D phys;
	public float moveSpeed = 1.0f;

	private List<Note> carriedNotes = new List<Note>();

	// Use this for initialization
	void Start () {
		phys = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		movement ();
	}

	void movement(){
		if (Input.GetKey (KeyCode.W)) {
			phys.velocity = Vector2.up * moveSpeed;
		} else if (Input.GetKey (KeyCode.S)) {
			phys.velocity = Vector2.up * moveSpeed * -1;
		} else if (Input.GetKey (KeyCode.A)) {
			phys.velocity = Vector2.right * moveSpeed * -1;
		} else if (Input.GetKey (KeyCode.D)) {
			phys.velocity = Vector2.right * moveSpeed;
		} else {
			phys.velocity = Vector2.zero;
		}
	}

	public void pickUp(Note inNote){
		string message = inNote.message;
		int defNum = inNote.defNum;
		string intendedCountry = inNote.intendedCountry;
		print (message);
		carriedNotes.Add (inNote);
	}

	void OnTriggerEnter2D(Collider2D other){
		Delegate del = other.GetComponent<Delegate> ();
		print ("Collided");
		if (del != null) {
			print ("Yep, It's a delegate");
			if(del.DeliverNote(carriedNotes)){
				carriedNotes.RemoveAt (0);
				print ("This is the Important one");
			}
		}
	}
}