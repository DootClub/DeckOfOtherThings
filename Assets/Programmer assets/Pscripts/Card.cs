	using System;
	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
	public event Action<Card> OnLevelEntered;
	public event Action<Card> OnLevelExit; 

	public int health;
	public int damage;

	public int moveSpeed;
	public float fireRate;

	public float visionRange;

	public virtual void Start()
	{
		if (OnLevelEntered != null)
		{
			// Prompt to pick a card
		}
	}

	public virtual void LevelExit()
	{
		if (OnLevelExit != null)
		{
			// Prompt to change card
		}
	}

	// Update is called once per frame
	void Update()
	{

	}
}
