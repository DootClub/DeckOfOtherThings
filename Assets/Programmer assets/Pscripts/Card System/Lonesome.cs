using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lonesome : Card
{

	// Use this for initialization
	void Start ()
	{
		
	}

	public override void CardActive()
	{
		base.CardActive();

		health++;
		damage++;

		moveSpeed++;
		fireRate++;

		visionRange++;
	}

	// Update is called once per frame
	void Update ()
	{
		
	}
}
