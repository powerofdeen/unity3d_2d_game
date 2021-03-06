﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public Vector2 speed = new Vector2(50, 50);

	private Vector2 movement;
	private Rigidbody2D rigidbodyComponent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");

		movement = new Vector2 (
			speed.x * inputX,
			speed.y * inputY
		);

	}

	void FixedUpdate() {
		if (rigidbodyComponent == null) {
			rigidbodyComponent = GetComponent<Rigidbody2D> ();
		}

		rigidbodyComponent.velocity = movement;
	}
}
