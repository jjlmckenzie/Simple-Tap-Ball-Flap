using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class AchievementManager : MonoBehaviour {

	public static AchievementManager instance;

	void Awake() {
		if (instance == null) {
			instance = this;
		}
	}



	// Use this for initialization
	void Start () {
		PlayGamesPlatform.Activate ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Login() {
		Social.localUser.Authenticate ((bool success) => {
		});
	}

	public void ShowAchievements() {
		if (Social.localUser.authenticated) {
			Social.ShowAchievementsUI ();
		} else {
			Login ();
		}
	}

	public void CheckAchievements() {

		if (ScoreManager.instance.score == 1) {
			Social.ReportProgress (GPGSIds.achievement_baby_ball, 100f, (bool success) => {});
			Debug.Log ("1 done");
		}

		if (ScoreManager.instance.score == 3) {
			Social.ReportProgress (GPGSIds.achievement_triple_terror, 100f, (bool success) => {});
			Debug.Log ("2 done");
		}

		if (ScoreManager.instance.score == 5) {
			Social.ReportProgress (GPGSIds.achievement_five_and_alive, 100f, (bool success) => {});
		}

		if (ScoreManager.instance.score == 15) {
			Social.ReportProgress (GPGSIds.achievement_bouncy_ball, 100f, (bool success) => {});
		}

		if (ScoreManager.instance.score == 25) {
			Social.ReportProgress (GPGSIds.achievement_king_ball, 100f, (bool success) => {});
		}

		if (ScoreManager.instance.score == 100) {
			Social.ReportProgress (GPGSIds.achievement_now_youre_just_showing_off, 100f, (bool success) => {});
		}




	}
}
