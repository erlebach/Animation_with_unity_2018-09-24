using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSplash : MonoBehaviour {
	public int how_long;
	public LevelManager level_manager;


	// Use this for initialization
	void Start () {
		// First argument must be a method in this class
		Invoke("ChangeScene", how_long);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ChangeScene() {
		level_manager.AutoLoad();
	}
}
