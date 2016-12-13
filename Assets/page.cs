using UnityEngine;
using System.Collections;

public class page : MonoBehaviour {

	public Rigidbody2D phys;
	public float moveSpeed = 1.0f;

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

	void pickUp(){
		if (Input.GetKey (KeyCode.Space)) {
			
		}
	}
}