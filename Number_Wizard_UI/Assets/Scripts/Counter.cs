using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour {
	public Text text;
	public int max_value = 10;  // maximum value of counter
	public LevelManager level_manager;

	// parameter to support counter speed
	private float base_value = 0f;
	public float time_between_updates = 1f;

	// Use this for initialization
	void Start () {
		//Debug.Log("Counter: time_between_updates: " + time_between_updates);
		base_value = 0f; // not sure this is required
		max_value = 10;
		text.text = "" + max_value;   // notice I am adding to an empty string
	}
	
	// Update is called once per frame
	void Update () {
		// Create a counter and control its speed

		// The second time counter is called, Time.time runs way way too fast. Why? 
		if (Time.time > base_value) {
			Debug.Log("base_value: " + base_value);
			Debug.Log("time: " + Time.time);
			max_value -= 1;
			text.text = "" + max_value;
			base_value += time_between_updates;
		}
	
		if (max_value <= 0) {
			Debug.Log("LoadScene CutScene");
			level_manager.LoadScene("CutScene");
		}
	}
}
