using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//written by Luke
public class MoveTowardsPlayer : MonoBehaviour
{
	public float moveSpeed;
	public BasePlayerStats player;
	public Health opposingHealth;
	public MoveTowardsPlayer self;
	public GameObject SelfTarget;
	public int damage;

	// Use this for initialization
	void Start ()
	{
		player = FindObjectOfType<BasePlayerStats>();
		self = FindObjectOfType<MoveTowardsPlayer>();
		opposingHealth = FindObjectOfType<Health>();
		
	}

	// Update is called once per frame
	void Update ()
	{
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed);
		
	}

	
	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.GetComponent<BasePlayerStats>())
		{
			Die();
			print("I'VE COLLIDEDDDD");
		}
	}

	public void Die()
	{
		opposingHealth.HealthAmount -= damage;
        Destroy(SelfTarget);
	}
}
