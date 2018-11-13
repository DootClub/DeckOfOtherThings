using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Written by Tegan Walsh-Jones
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
	
	}

	public virtual void LevelEnter()
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

	public virtual void CardActive()
	{
		// Override with a card's active ability
	}

	public virtual void CardPassive()
	{
		// Override with a card's passive ability
	}

	// Update is called once per frame
	void Update()
	{

	}
}
