using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	bool gameOver;


	void Awake() {

		DontDestroyOnLoad (this.gameObject);

		if (instance == null) {
			instance = this;
		} else {
			Destroy (this.gameObject);
		}
	}

	public void GameStart () {
		GameObject.Find ("FenceSpawner").GetComponent<FenceSpawner>().StartSpawningFences();
		UiManager.instance.GameStart ();
	}

	public void GameOver() {
		gameOver = false;
		GameObject.Find ("FenceSpawner").GetComponent<FenceSpawner>().StopSpawningFences();
		ScoreManager.instance.StopScore ();
		UiManager.instance.GameOver ();
		UnityAdManager.instance.ShowAd ();
	}

	// Use this for initialization
	void Start () {
		gameOver = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
