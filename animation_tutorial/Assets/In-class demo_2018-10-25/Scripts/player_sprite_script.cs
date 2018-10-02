using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Animation Tutorial
// https://gamedevacademy.org/unity-3d-animations-tutorial/

public class player_sprite_script : MonoBehaviour {
	public float speed = 1;
	public float jump_speed;
	public float jump_force = 15f;
	private Rigidbody2D rb;
	private Animator animator;
	private bool isGrounded = true;
	// Add Sprite Renderer

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
		//sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal");

		// Continuous walking
        transform.position += x * speed * Vector3.right * Time.deltaTime;

		if (Input.GetKey(KeyCode.Space)) {
			print("hit space, bool = " + isGrounded);
			if (isGrounded == true) {
				print("about to jump");
				//Switch to jump animation
				animator.SetTrigger("isJumping");
				rb.AddForce(new Vector2(0f,jump_force));
				isGrounded = false;
			}	
		} else if (x > 0) {
			transform.localScale = new Vector3(1f,1f,1f);
			animator.SetTrigger("isWalking");
		} else if (x < 0) {
			transform.localScale = new Vector3(-1f,1f,1f);
			animator.SetTrigger("isWalking");
		} else {
			animator.SetTrigger("isIdle");
		}

 
	}

	 void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Ground") == true) {
			print("hit the ground");
			isGrounded = true;
		}
	}
	
}

// Implement jumping
// What happens if spacebar is kept down? 
// Control groundness (use a flag is_grounded)
// What if player hits a platform overhead? How to handle this? 

// Add a tree and jiggle it
