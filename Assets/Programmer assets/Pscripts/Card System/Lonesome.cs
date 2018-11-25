using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lonesome : CardBase
{

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public override void Health()
	{
		health.HealthAmount = 100;
	}

	public override void MoveSpeed ()
	{
		moveSpeed.speed = 6f;
	}
}
