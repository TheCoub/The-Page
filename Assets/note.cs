using UnityEngine;
using System.Collections;

public class Note : MonoBehaviour {

	//Create an initilize function that will set all the proper variable on awake. 

	public string message = "Hi, wanna play hangman?";
	public int defNum = 1;
	//Make a list that holds the defnum and Message and have the initialize randomly pick a note.

	// Use this for initialization
	void Start () {
		print (message);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		Page page = other.GetComponent<Page> ();
		if (page != null) {
			page.pickUp (this);
		}
		Destroy (this.gameObject);
	}
}
