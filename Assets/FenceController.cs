using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceController : MonoBehaviour {

	public float speed;
	public float upDownSpeed;
	Rigidbody2D rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		MoveFence ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void MoveFence() {
		rb.velocity = new Vector2 (-speed, 0);
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "FenceRemoval") {
			Destroy (gameObject);
		}
	}
}
