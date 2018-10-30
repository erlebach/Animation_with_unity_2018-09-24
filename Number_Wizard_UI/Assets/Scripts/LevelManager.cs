using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public int next_scene = 0;
	public int nb_seconds = 0;

	// Use this for initialization
	void Start () {
		if (nb_seconds != 0) {
			Invoke("AutoLoad", nb_seconds);
		}
	}

	 public void LoadNextScene() {
		int idx = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(idx+1);
	}

	public void LoadScene(string scene_name) {
		Debug.Log("LoadScene: " + scene_name);
		SceneManager.LoadScene(scene_name);
	}

	public void QuitGame() {
		Application.Quit(); // called but does not work
	}

	public void AutoLoad() {
		LoadScene("Start");
	}
}
