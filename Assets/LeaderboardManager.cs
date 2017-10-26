using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class LeaderboardManager : MonoBehaviour {

	public static LeaderboardManager instance;

	void Awake() {
		if (instance == null) {
			instance = this;
		}
	}




	// Use this for initialization
	void Start () {
		PlayGamesPlatform.Activate ();
		Login ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void Login() {
		Social.localUser.Authenticate ((bool success) => {
		});
	}

	public void AddScoreToLeaderboard() {
		Social.ReportScore (PlayerPrefs.GetInt("Score"), "CgkIqfrL3r0GEAIQAQ", (bool success) => {
			
		});
	}

	public void ShowLeaderboard() {
		if (Social.localUser.authenticated) {
			PlayGamesPlatform.Instance.ShowLeaderboardUI ("CgkIqfrL3r0GEAIQAQ");
		} else {
			Login ();
		}
	}

}
