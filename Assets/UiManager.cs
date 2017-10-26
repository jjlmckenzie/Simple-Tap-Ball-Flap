using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {

	public static UiManager instance;

	public Text scoreText;
	public Text highScoreText;
	public GameObject gameOverPanel;
	public GameObject startUI;
	public Text startText;


	void Awake() {
		if (instance == null) {
			instance = this;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = ScoreManager.instance.score.ToString();
	}

	public void GameStart() {
		startUI.SetActive (false);
	}

	public void GameOver() {
		highScoreText.text = "Personal Best: " + PlayerPrefs.GetInt ("HighScore").ToString ();
		gameOverPanel.SetActive (true);
	}

	public void Replay() {
		SceneManager.LoadScene (1);
	}

	public void Menu() {
		SceneManager.LoadScene (0);
	}

	public void ShowLeaderboard() {
		LeaderboardManager.instance.ShowLeaderboard ();
	}
}
