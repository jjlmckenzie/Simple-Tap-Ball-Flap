using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UnityAdManager : MonoBehaviour {

	public static UnityAdManager instance;

	void Awake() {

		DontDestroyOnLoad (this.gameObject);

		if (instance == null) {
			instance = this;
		} else {
			Destroy (this.gameObject);
		}
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void ShowAd(){

		if (PlayerPrefs.HasKey ("Adcount") ){

			if (Advertisement.IsReady ("video") && PlayerPrefs.GetInt ("Adcount") >= 2 && PlayerPrefs.GetInt ("Score") <= 30) {
				Advertisement.Show ();
				PlayerPrefs.SetInt ("Adcount", 0);
			} else if (PlayerPrefs.GetInt ("Score") > 30) {
				if (Advertisement.IsReady ("rewardedVideo") ) {
					Advertisement.Show ();
					PlayerPrefs.SetInt ("Adcount", 0);
				}

			} else {
				int i = PlayerPrefs.GetInt ("Adcount") + 1;
				PlayerPrefs.SetInt ("Adcount", i);
			}

		} else {

			PlayerPrefs.SetInt ("Adcount", 0);


				
		}

		//SceneManager.LoadScene (0);


	}
}
