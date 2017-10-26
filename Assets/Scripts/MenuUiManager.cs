using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUiManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LeaderboardManager.instance.Login ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Play() {
		SceneManager.LoadScene ("level1");
	}

	public void ShowLDB() {
		LeaderboardManager.instance.ShowLeaderboard ();
	}
}
