using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
	public float moveSpeed;
	public BasePlayerStats player;
	public MoveTowardsPlayer self;
	public GameObject SelfTarget;

	// Use this for initialization
	void Start ()
	{
		player = FindObjectOfType<BasePlayerStats>();
		self = FindObjectOfType<MoveTowardsPlayer>();
	}

	// Update is called once per frame
	void Update ()
	{
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed);
		
	}

	//this doesn't work :(
	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.GetComponent<BasePlayerStats>())
		{
			Destroy(SelfTarget);
			print("BEEP");
		}
	}
}
