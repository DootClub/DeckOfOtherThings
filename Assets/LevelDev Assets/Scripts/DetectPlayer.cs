using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
	public BasePlayerStats player;
	float dist;
	public float sightRange; 
	public MoveTowardsPlayer self;


	// Use this for initialization
	void Start ()
	{
		self = GetComponent<MoveTowardsPlayer>();
		self.enabled = false;
		player = FindObjectOfType<BasePlayerStats>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		Distance();

		if (dist <= sightRange)
		{
			self.enabled = true;
//			print("I'M COMIN FOR YA");
		}
		else
		{
			self.enabled = false;
//  			print("o fuk where u go");
		}
	}

	void Distance()
	{
		if (player)
		{
			dist = Vector2.Distance(player.transform.position, transform.position);
		}
	}
	
}
