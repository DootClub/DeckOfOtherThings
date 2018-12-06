using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
	public BasePlayerStats player;
	public Health opposingHP;
	public GameObject self;
	public int addedHP;


	// Use this for initialization
	void Start ()
	{

		player = FindObjectOfType<BasePlayerStats>();
		opposingHP = player.GetComponent<Health>();
	}

	// Update is called once per frame
	void Update ()
	{
		
	}

	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.GetComponent<BasePlayerStats>())
		{
			opposingHP.HealthAmount += addedHP;
			Destroy(self);
		}
	}
}
