﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public int next_scene = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	 public void LoadNextScene() {
		 print("gordon");
		int idx = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(idx+1);
		Debug.Log("idx= " + idx);
	}
}