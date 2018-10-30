using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManagerDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void LoadLevel(string name) {
		print("entered LoadLevel " + name);
		SceneManager.LoadScene(name);

	}

	public void LoadNextLevel() {
	}
}
