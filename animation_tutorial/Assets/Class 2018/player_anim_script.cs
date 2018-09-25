using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_anim_script : MonoBehaviour {
	public float speed = 10;
	Animator my_animator;

	// Use this for initialization
	void Start () {
		my_animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");
		print(x);
		transform.position += x * speed * Time.deltaTime * (new Vector3(1f,0f,0f));

		if (x > 0) {
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
