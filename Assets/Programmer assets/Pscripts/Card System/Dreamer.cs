using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Written by Tegan Walsh-Jones
public class Dreamer : CardBase
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

		if (Random.value < 0.5f)
		{
			playerHealth.HealthAmount = 150;
		}

		else
		{
			playerHealth.HealthAmount = 50;
		}
	}

	public override void ChangeMoveSpeed()
	{
		playerMoveSpeed = FindObjectOfType<TouchControls>();

		if (Random.value < 0.5f)
		{
			playerMoveSpeed.speed = 9;
		}

		else
		{
			playerMoveSpeed.speed = 3;
		}
	}
}
