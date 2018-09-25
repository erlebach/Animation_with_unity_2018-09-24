using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_sprite_script : MonoBehaviour {
	public float speed = 1;
	public float jump_speed;
	private Rigidbody2D rb;
	private Animator animator;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal");

		if (x < 0) {
			animator.SetTrigger("isWalking");
		} else {

		}
	}
}
