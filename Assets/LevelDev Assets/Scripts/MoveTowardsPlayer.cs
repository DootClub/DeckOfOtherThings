using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//written by Luke
public class MoveTowardsPlayer : MonoBehaviour
{
	public float moveSpeed;
	public BasePlayerStats player;
	public Health opposingHealth;
	public GameObject SelfTarget;
	public int damage;
    public Analytics CustomAnalyser;

	// Use this for initialization
	void Start ()
	{
		player = FindObjectOfType<BasePlayerStats>();
		opposingHealth = player.GetComponent<Health>();


        GetComponent<Health>().OnDeath += Die;
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
            CustomAnalyser = collision.gameObject.GetComponent<Analytics>();
            CustomAnalyser.HitEnemy();
			print("I'VE COLLIDEDDDD");
            GetComponent<Health>().Change(-100);
		}
	}

	public void Die()
	{
		opposingHealth.HealthAmount -= damage;
        Destroy(SelfTarget);
	}
}
