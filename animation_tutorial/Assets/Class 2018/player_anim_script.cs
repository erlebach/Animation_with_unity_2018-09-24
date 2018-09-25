using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_anim_script : MonoBehaviour {
	public float speed = 10;
	public Rigidbody2D rb;
	Animator my_animator;

	// Use this for initialization
	void Start () {
		my_animator = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");
		transform.position += x * speed * Time.deltaTime * (new Vector3(1f,0f,0f));

		if (Input.GetKey(KeyCode.Space)) {
			my_animator.SetTrigger("IsJumping");
			rb.AddForce(new Vector2(0f, 20f));
			print("jump");
		} else if (x > 0) {
			my_animator.SetTrigger("isWalking");
			transform.localScale = new Vector3(1f,1f,1f);
		} else if (x < 0) {
			my_animator.SetTrigger("isWalking");
			transform.localScale = new Vector3(-1f,1f,1f);
		} else {
			my_animator.SetTrigger("isIdle");
		}
	}
}
