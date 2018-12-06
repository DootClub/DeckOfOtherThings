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



    public AudioClip clip;
    public AudioSource Source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

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
			print("I'VE COLLIDEDDDD");
            GetComponent<Health>().Change(-100);
		}
	}



    public void Die()
    {
        GetComponent<BoxCollider2D>().enabled = false;
        //GetComponent<>()
        StartCoroutine(DestroyEnemy());
        
    }

    private IEnumerator DestroyEnemy()
    {
        opposingHealth.HealthAmount -= damage;
        yield return new WaitForSeconds(1);
        Destroy(SelfTarget);
    }
}
