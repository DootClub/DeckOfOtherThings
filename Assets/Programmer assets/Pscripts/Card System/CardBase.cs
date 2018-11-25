using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Written by Tegan Walsh-Jones
public class CardBase : MonoBehaviour
{
	// Array used to group and access all of the cards, maybe?
	public CardBase[] AllCards = new CardBase[3];

	public TouchControls moveSpeed;

	public Health health;

	// Use this for initialization
	void Start ()
	{
		Health healthScript = health.GetComponent<Health>();
		healthScript.HealthAmount = 100;

		TouchControls movementScript = moveSpeed.GetComponent<TouchControls>();
		movementScript.speed = 6f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void Cards ()
	{
		// Not sure if this will be used, but might be used to display the cards to the player
	}

	public virtual void Health ()
	{
		if (health != null)
		{
			health.HealthAmount = 100;
		}
		// Used by cards to change the players health
	}

	public virtual void MoveSpeed ()
	{
		if (moveSpeed != null)
		{
			moveSpeed.speed = 6f;
		}
		// Used by cards to change the players movement speed
	}
}
