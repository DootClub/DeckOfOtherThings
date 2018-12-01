using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Written by Tegan Walsh-Jones
public class Lonesome : CardBase
{
	// Use this for initialization
	void Start ()
	{
		ChangeHealth();
		ChangeMoveSpeed();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public override void ChangeHealth()
	{
		playerHealth = FindObjectOfType<Health>();

		playerHealth.HealthAmount = 100;
	}

	public override void ChangeMoveSpeed ()
	{
		playerMoveSpeed = FindObjectOfType<TouchControls>();

		playerMoveSpeed.speed = 6;
	}
}
