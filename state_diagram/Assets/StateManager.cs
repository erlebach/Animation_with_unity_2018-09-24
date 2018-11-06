using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
	enum State {
		STATE_STANDING, 
		STATE_JUMPING,
		STATE_DUCKING,
		STATE_DIVING
	}

	private State state_;

	void Start () {
		state_ = State.STATE_STANDING;
		print("Inital state: standing");
	}
	
	// Update is called once per frame
	void Update () {
		handleInput();
	}

	// List of keys: 
	// https://docs.unity3d.com/Manual/ConventionalGameInput.html

	void handleInput() 
	{
		switch (state_)
		{
			case State.STATE_STANDING:
			if (Input.GetKeyDown("b")) // single frame
			{
				state_ = State.STATE_JUMPING;
				print("standing --> jumping");
				//yVelocity_ = JUMP_VELOCITY;
				//setGraphics(IMAGE_JUMP);
			}
			else if (Input.GetKey("d"))
			{
				state_ = State.STATE_DUCKING;
				print("standing --> ducking");
				//setGraphics(IMAGE_DUCK);
			}
			break;

			case State.STATE_JUMPING:
			if (Input.GetKeyDown("d"))
			{
				state_ = State.STATE_DIVING;
				print("jumping --> diving");
				//setGraphics(IMAGE_DIVE);
			}
			break;

			case State.STATE_DUCKING:
			if (Input.GetKeyUp("d"))
			{
				state_ = State.STATE_STANDING;
				print("ducking --> standing");
				//setGraphics(IMAGE_STAND);
			}
			break;
		}
	}
}
