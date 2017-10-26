using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour {

	public float upForce;
	Rigidbody2D rb;
	bool started;
	bool gameOver;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		started = false;
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!started) {
			if (Input.GetMouseButtonDown (0)) {
				started = true;
				rb.isKinematic = false;
				GameManager.instance.GameStart ();
			}
		} else {
			if (Input.GetMouseButtonDown (0) && !gameOver) {
				rb.velocity = Vector2.zero;
				rb.AddForce (new Vector2 (0, upForce));
			}
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		GameManager.instance.GameOver ();
	}

	void OnTriggerEnter2D(Collider2D col) {

		if (col.gameObject.tag == "Fence" && !gameOver) {
			gameOver = true;
			rb.isKinematic = true;
			rb.velocity = Vector2.zero;
			rb.velocity = new Vector2 (-2, 0);

			GameManager.instance.GameOver ();
		}
		


		if (col.gameObject.tag == "ScoreChecker" && !gameOver) {
			ScoreManager.instance.IncrementScore ();
		}
	}
}
