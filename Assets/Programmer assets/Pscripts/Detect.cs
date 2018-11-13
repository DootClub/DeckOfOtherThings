using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Written by Tegan Walsh-Jones
public class Detect : MonoBehaviour
{
	// Runs when a trigger has been entered
	void OnTriggerEnter2D (Collider2D other)
	{
		// If the collider 'other' has the tag "Enemy", announce that an enemy was detected
		if (other.gameObject.tag == "Enemy")
		{
			Debug.Log("An enemy was detected");
		}
	}
}
