using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

// Written by Tegan Walsh-Jones
public class CardBase : MonoBehaviour
{
	public Health playerHealth;
	public TouchControls playerMoveSpeed;

	public Lonesome lonesome;
	public Bulwark bulwark;
	public Dreamer dreamer;
	
	// Use this for initialization
	void Start ()
	{
		playerHealth = FindObjectOfType<Health>();
		playerMoveSpeed = FindObjectOfType<TouchControls>();

		lonesome = FindObjectOfType<Lonesome>();
		bulwark = FindObjectOfType<Bulwark>();
		dreamer = FindObjectOfType<Dreamer>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void Cards ()
	{
		// Not sure if this will be used, but might be used to display the cards to the player
	}

	public virtual void ChangeHealth ()
	{
		// Used by cards to change the players health
	}

	public virtual void ChangeMoveSpeed ()
	{
		// Used by cards to change the players movement speed
	}
}
