using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitSplash : MonoBehaviour {

	public LevelManagerDemo level_manager;
	public int start_after = 10;

	// Use this for initialization
	void Start () {
		Invoke("LoadLevel", start_after);
	}
	
	public void LoadLevel() {
		print("LoadLevel from splash");
		level_manager.LoadLevel("StartMenu");
	}
}
